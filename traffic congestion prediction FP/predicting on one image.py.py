import cv2
import numpy as np
from sklearn.neighbors import KNeighborsClassifier
import glob 
#from sklearn import metrics
from sklearn.naive_bayes import GaussianNB
#import matplotlib.pyplot as plt
from PyQt5 import QtCore, QtGui, QtWidgets
from tkinter import filedialog
import tkinter as tk


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(817, 508)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.pushButton = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton.setGeometry(QtCore.QRect(110, 320, 111, 23))
        self.pushButton.setObjectName("pushButton")
        self.pushButton_2 = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton_2.setGeometry(QtCore.QRect(110, 380, 111, 41))
        self.pushButton_2.setObjectName("pushButton_2")
        self.line = QtWidgets.QFrame(self.centralwidget)
        self.line.setGeometry(QtCore.QRect(330, 0, 16, 461))
        self.line.setFrameShape(QtWidgets.QFrame.VLine)
        self.line.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line.setObjectName("line")
        self.groupBox = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBox.setGeometry(QtCore.QRect(370, 20, 421, 421))
        self.groupBox.setObjectName("groupBox")
        self.tabWidget = QtWidgets.QTabWidget(self.groupBox)
        self.tabWidget.setGeometry(QtCore.QRect(10, 20, 401, 391))
        self.tabWidget.setObjectName("tabWidget")
        self.tab = QtWidgets.QWidget()
        self.tab.setObjectName("tab")
        self.listView = QtWidgets.QListView(self.tab)
        self.listView.setGeometry(QtCore.QRect(10, 10, 381, 351))
        self.listView.setObjectName("listView")
        self.tabWidget.addTab(self.tab, "")
        self.Visualisation = QtWidgets.QWidget()
        self.Visualisation.setObjectName("Visualisation")
        self.graphicsView = QtWidgets.QGraphicsView(self.Visualisation)
        self.graphicsView.setGeometry(QtCore.QRect(50, 30, 256, 192))
        self.graphicsView.setObjectName("graphicsView")
        self.tabWidget.addTab(self.Visualisation, "")
        self.commandLinkButton = QtWidgets.QCommandLinkButton(self.centralwidget)
        self.commandLinkButton.setGeometry(QtCore.QRect(10, 20, 311, 291))
        self.commandLinkButton.setText("")
        icon = QtGui.QIcon()
        icon.addPixmap(QtGui.QPixmap(""), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        self.commandLinkButton.setIcon(icon)
        self.commandLinkButton.setIconSize(QtCore.QSize(500, 500))
        self.commandLinkButton.setObjectName("commandLinkButton")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 817, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar"
                                     )
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        self.tabWidget.setCurrentIndex(0)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)
        
        self.pushButton.clicked.connect(self.choose)

                                          
                                          
                                        
                                          
        
   
        
    def Analyse(fname):
        
        image_hist = []
        label = []
        imagefile2 = glob.glob("C:\\Users\\Daphin\\Desktop\\traffic\\*.JPG")
        imagefile1= glob.glob("C:\\Users\\Daphin\Desktop\\No traffic\\*.JPG")
        clas=1
        for file in imagefile1:
            gray_img = cv2.imread(file, cv2.IMREAD_GRAYSCALE)
            hist = cv2.calcHist([gray_img],[0],None,[256],[0,256])
            image_hist.append(hist)
            label.append(clas)
        clas2=2
        for file1 in imagefile2:
            gray_img = cv2.imread(file1, cv2.IMREAD_GRAYSCALE)
            hist = cv2.calcHist([gray_img],[0],None,[256],[0,256])
            image_hist.append(hist)
            label.append(clas2)
        data =np.array(image_hist)
        labels =np.array(label)
        Data =data[:,:,0]
        
#predicting on one image using naive bayes (gaussian model)
        print('RESULTS PRODUCED WHILE PEDICTING ON ONE IMAGE')
        model = GaussianNB()
        model.fit(Data, labels)
        gray_img = cv2.imread(fname, cv2.IMREAD_GRAYSCALE)
        #r = cv2.selectROI(gray_img[400:500, 450:550])
        cv2.imshow('fname',gray_img )
        hist=cv2.calcHist([gray_img],[0],None,[256],[0,256])
        predicted = model.predict(hist)
        print(predicted)
        n = predicted.shape
        if n == 1:
            print("THERE IS NO TRAFFIC CONGESTION ON THE ROAD")
 #                      
        else:
            print("THERE IS TRAFFIC CONGESTION ON THE ROAD")
               
                   
#   predicting on one image using KNN
 #       print('RESULTS PRODUCED BY KNN WHILE PREDICTING ON ONE IMAGE')
#        knn = KNeighborsClassifier(n_neighbors=5)
#        knn.fit(Data, labels)
#        print ('girl')
       # gray_img = cv2.imread(fname, cv2.IMREAD_GRAYSCALE)
        #r = cv2.selectROI(gray_img[400:500, 450:550])
       # cv2.imshow('fname',gray_img )
       # hist=cv2.calcHist([gray_img],[0],None,[256],[0,256])
#        predictedknn = knn.predict(hist)
#        print(predictedknn)
#        k = predictedknn.shape
#        if k == 1:
#            print("THERE IS NO TRAFFIC CONGESTION ON THE ROAD")
# #                      
#        else:
#            print("THERE IS TRAFFIC CONGESTION ON THE ROAD")
#     
#
#        
 # enables user to upload an image to the interface 
    def choose(self):
        root = tk.Tk()
        root.withdraw()
        fname = tk.filedialog.askopenfilename()
        
        
        
        icon = QtGui.QIcon(fname)
        icon.addPixmap(QtGui.QPixmap(fname), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        self.commandLinkButton.setIcon(icon)
        self.commandLinkButton.setIconSize(QtCore.QSize(500, 500))
        
        Ui_MainWindow.Analyse(fname)
        
           


    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "MainWindow"))
        self.pushButton.setText(_translate("MainWindow", "Choose Image"))
        self.pushButton_2.setText(_translate("MainWindow", "Start Analysis"))
        self.groupBox.setTitle(_translate("MainWindow", "ANALYSIS RESULTS"))
        self.tabWidget.setTabText(self.tabWidget.indexOf(self.tab), _translate("MainWindow", "Statistical data"))
        self.tabWidget.setTabText(self.tabWidget.indexOf(self.Visualisation), _translate("MainWindow", "Visualisations"))
    
    

if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())
    
   
   
    


