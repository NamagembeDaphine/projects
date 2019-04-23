import cv2
import numpy as np
import glob
from sklearn import svm
from sklearn.metrics import precision_recall_curve
from sklearn.metrics import average_precision_score
from sklearn import tree
from sklearn.neighbors import KNeighborsClassifier 
from sklearn import metrics
from sklearn.naive_bayes import GaussianNB
import matplotlib.pyplot as plt
from sklearn.cross_validation import train_test_split
from sklearn.metrics import roc_curve, auc
from sklearn.preprocessing import label_binarize


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
y = label_binarize(labels, classes=[ 1, 2])
n_classes = y.shape[1]
Data = data[:,:,0]

train_Data, test_Data, train_labels, test_labels = train_test_split(Data, y, test_size=0.45)

#using Naive bayes
print('RESULTS PRODUCED BY NAIVE')
model = GaussianNB()
model.fit(train_Data, train_labels)
expected =test_labels
predicted = model.predict(test_Data)
yp =np.vstack(predicted)
print(metrics.classification_report(expected, predicted))
print(metrics.confusion_matrix(expected, predicted))

# using KNN
print('RESULTS PRODUCED BY KNN')
knn = KNeighborsClassifier(n_neighbors=3)
knn.fit(train_Data, train_labels)
expectedknn = test_labels
predictedknn = knn.predict(test_Data)
ypknn =np.vstack(predictedknn)
print(metrics.classification_report(expectedknn, predictedknn))
print(metrics.confusion_matrix(expectedknn, predictedknn))

#using SVM
print('RESULTS PRODUCED BY SVM')
clf = svm.SVC()
clf.fit(train_Data, train_labels)
expectedsvm = test_labels
predictedsvm = clf.predict(test_Data)
ypsvm =np.vstack(predictedsvm)
print(metrics.classification_report(expectedsvm, predictedsvm))
print(metrics.confusion_matrix(expectedsvm, predictedsvm))

#using decision tree
print('RESULTS PRODUCED BY Decision tree')
clf = tree.DecisionTreeClassifier()
clf.fit(train_Data, train_labels)
expectedtree = test_labels
predictedtree = clf.predict(test_Data)
yptree =np.vstack(predictedtree)
print(metrics.classification_report(expectedtree, predictedtree))
print(metrics.confusion_matrix(expectedtree, predictedtree))

## Computing ROC curves for each classifier on one graph
fprnb = dict()
tprnb = dict()
roc_aucnb = dict()
fprknn = dict()
tprknn = dict()
roc_aucknn = dict()
fprsvm = dict()
tprsvm = dict()
roc_aucsvm = dict()
fprtree = dict()
tprtree = dict()
roc_auctree = dict()

for i in range(n_classes):
    fprnb[i], tprnb[i], _ = roc_curve(expected[i], yp[i])
    roc_aucnb[i] = auc(fprnb[i], tprnb[i])
    
    fprknn[i], tprknn[i], _ = roc_curve(expectedknn[i], ypknn[i])
    roc_aucknn[i] = auc(fprknn[i], tprknn[i])
    
    fprsvm["micro"], tprsvm["micro"], _ = roc_curve(expectedsvm.ravel(), predictedsvm.ravel())
    roc_aucsvm["micro"] = auc(fprsvm["micro"], tprsvm["micro"])

    fprtree["micro"], tprtree["micro"], _ = roc_curve(expectedtree.ravel(), predictedtree.ravel())
    roc_auctree["micro"] = auc(fprtree["micro"], tprtree["micro"])
# # Compute micro-average ROC curve and ROC area

fprnb["micro"], tprnb["micro"], _ = roc_curve(expected.ravel(), predicted.ravel())
roc_aucnb["micro"] = auc(fprnb["micro"], tprnb["micro"])

fprknn["micro"], tprknn["micro"], _ = roc_curve(expectedknn.ravel(), predictedknn.ravel())
roc_aucknn["micro"] = auc(fprknn["micro"], tprknn["micro"])

fprsvm["micro"], tprsvm["micro"], _ = roc_curve(expectedsvm.ravel(), predictedsvm.ravel())
roc_aucsvm["micro"] = auc(fprsvm["micro"], tprsvm["micro"])

fprtree["micro"], tprtree["micro"], _ = roc_curve(expectedtree.ravel(), predictedtree.ravel())
roc_auctree["micro"] = auc(fprtree["micro"], tprtree["micro"])

# Plot all ROC curves
plt.plot(fprnb["micro"], tprnb["micro"], color = 'red', label= 'Naive Bayes')
plt.plot(fprknn["micro"], tprknn["micro"], color = 'blue', label= 'KNN')
plt.plot(fprsvm["micro"], tprsvm["micro"], color = 'orange', label='SVM')
plt.plot(fprtree["micro"], tprtree["micro"], color = 'yellow', label='Decision Tree')
plt.xlabel('False Positive Rate')
plt.ylabel('True Positive Rate')
plt.ylim([0.0, 1.1])
plt.xlim([0.0, 1.0])
plt.title('ROC curves showing the performance of Naive Bayes, KNN, SVM and Decision Tree ')
plt.legend(loc="lower right")
plt.show()


# Compute Precision-Recall and plot curve
#precision = dict()
#recall = dict()
#average_precision = dict()
#for i in range(n_classes):
#    precision[i], recall[i], _ = precision_recall_curve(expected[i],yp[i])
#    average_precision[i] = average_precision_score(expected[i], yp[i])
#
## Compute micro-average ROC curve and ROC area
#precision["micro"], recall["micro"], _ = precision_recall_curve(expected.ravel(),predicted.ravel())
#average_precision["micro"] = average_precision_score(expected, predicted,average="micro")
#
#
## Plot Precision-Recall curv
#plt.plot(recall[0], precision[0], color='navy',label='Precision-Recall curve')
#plt.xlabel('Recall')
#plt.ylabel('Precision')
#plt.ylim([0.0, 1.05])
#plt.xlim([0.0, 1.0])
#plt.title('Precision-Recall Curve')
#plt.legend(loc="lower left")
#plt.show()