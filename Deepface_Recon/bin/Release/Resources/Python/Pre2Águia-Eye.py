import os
import Relatorio
os.environ["TF_USE_LEGACY_KERAS"] = "1"
from tensorflow.python._pywrap_tensorflow_internal import *
import pandas as pd
from deepface import DeepFace
from multiprocessing import Pool, Process
from multiprocessing.dummy import Pool as ThreadPool
import numpy
import cv2
import shutil



AbsPath = (os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
AbsDbPath = os.path.join(AbsPath, "Dbs")

Db = os.listdir(AbsDbPath)
skeleton = {"Confidence": [], "Candidate": [],"Database": [] }
BulkMatches = pd.DataFrame(skeleton)

def LightReconPost(CsharpIndicator: str):

    AbsTSPath = os.path.join(AbsPath, "Sessions", CsharpIndicator, "PicturesTS")
    AbsTAPath = os.path.join(AbsPath, "Sessions", CsharpIndicator, "PicturesTa")
    Cvstemps = os.path.join(AbsPath, "Sessions", CsharpIndicator, "CSVtemps")

    for File in os.listdir(AbsTSPath):
        Candidate = os.path.join(AbsTSPath, File)
        for data in Db:
            database = os.path.join(AbsDbPath, data)
            print(database)

            if os.path.exists(Candidate) == False:
                break
            else:
                Matches = DeepFace.find(img_path=Candidate, db_path=database, enforce_detection=False,
                                        detector_backend="mtcnn")  # mtcnn
                for Match in Matches:
                    if Match.empty == False:
                        tempList = [int(Match.loc[0, 'confidence']), Candidate, database]
                        BulkMatches.loc[len(BulkMatches)] = tempList
        shutil.move(Candidate, AbsTAPath)
    Filter1 = BulkMatches[BulkMatches['Confidence'] > 71]
    counter = 0
    Iterated = []
    for pic in os.listdir(AbsTAPath):  #This is now AbsTAPath because depending on the settings new images could be coming in at AbsTSPath #Note, Implement moving the images after recon
        Fullpath = os.path.join(AbsTSPath, pic)
        Confirm = Filter1['Candidate'].apply(lambda x: "Y" if x == Fullpath else "N")

        for result in Confirm:
            if result == "Y":
                flag = any(x == pic for x in Iterated)
                if flag == False:
                    Filter2 = Filter1[Filter1['Candidate'].str.contains(pic)]
                    print(Filter2)
                    Iterated.append(pic)
                    path = os.path.join(Cvstemps, str(counter))
                    Filter2.to_csv(path + ".csv", index=False)
                    counter += 1
                break
    Relatorio.DocxCreation(AbsPath + r"\Relatórios\re\Logo.png",
                           os.path.join(AbsPath, "Sessions", CsharpIndicator, "CSVtemps"),
                           os.path.join(AbsPath, "Sessions", CsharpIndicator, "TimeLog", "TimeDecoder.csv"),
                           AbsPath + r"\Relatórios")


def ModeShift():
    csvArgs = os.path.join(AbsPath, "Temp", "CSVArgument.csv")  # File Telling Which Sessions to Process
    ModeData = pd.read_csv(csvArgs)  # Make the CSV file into dataframe

    FilteredData = ModeData.drop_duplicates()  # There is inevitably going to be duplicates, but each session only needs to be processed once

    argList = FilteredData.loc[:, "Argument"]  # This only cares about the Argument column, but in the future, more complex logic can be done with the Sync and Mode columns
    print(list(argList))
    with open(os.path.join(AbsPath, "Temp", "Order.txt"), "r") as OrderContents:
        SessionOrder = OrderContents.readlines()
    for arg in argList:
        if str(arg) == SessionOrder[0]:
            LightReconPost(str(arg))



ModeShift()