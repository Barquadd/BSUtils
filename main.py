from PyQt5 import QtCore, QtGui, QtWidgets
import subprocess
import os
import psutil

# Check if user is using oculus
if os.path.isfile(r'C:\Program Files\Oculus\Support\oculus-diagnostics\OculusDebugToolCLI.exe'):
    oculusUser = True
else:
    oculusUser = False

def aswDisable():
    #There is 100% a better way to do this but I'm not good at programming
    with open('aswDisable.bat', 'w') as aswDisableScript:
        aswDisableScript.write('echo server:asw.Off > "aswDisableCmds.txt"\necho exit >> "aswDisableCmds.txt"\n' + r'call "C:\Program Files\Oculus\Support\oculus-diagnostics\OculusDebugToolCLI.exe" -f "%~dp0\aswDisableCmds.txt"' + '\ndel "aswDisableCmds.txt"')
    subprocess.call(['aswDisable.bat'])
    os.remove('aswDisable.bat')
    aswDisableBtn.setEnabled(False)

def changeBSPriority():
    BSOpen = False
    for proc in psutil.process_iter():
        if proc.name() == 'Beat Saber.exe':
            BSOpen = True
            psutil.Process(proc.pid).nice(psutil.HIGH_PRIORITY_CLASS)
            alertBox2 = QtWidgets.QMessageBox()
            alertBox2.setWindowTitle("BSUtils")
            alertBox2.setText("Beat Saber Priority Has Been Set To High!")
            alertBox2.exec_()
    if BSOpen != True:
        alertBox = QtWidgets.QMessageBox()
        alertBox.setWindowTitle("BSUtils")
        alertBox.setText("Priority Could Not Be Changed, Is Beat Saber Open?")
        alertBox.exec_()

class Ui_Dialog(object):
    def setupUi(self, Dialog):
        Dialog.setObjectName("Dialog")
        Dialog.setEnabled(True)
        #I doubt this application is gonna handle 4k monitors well, but I doubt many people will use this anyway.
        Dialog.resize(400, 300)
        self.pushButton = QtWidgets.QPushButton(Dialog)
        self.pushButton.setGeometry(QtCore.QRect(20, 20, 81, 31))
        font = QtGui.QFont()
        font.setBold(False)
        font.setWeight(50)
        self.pushButton.setFont(font)
        self.pushButton.setObjectName("pushButton")
        self.pushButton.clicked.connect(aswDisable)
        global aswDisableBtn
        aswDisableBtn = self.pushButton
        if oculusUser == False:
            aswDisableBtn.setEnabled(False)
        self.changePriority = QtWidgets.QPushButton(Dialog)
        self.changePriority.setGeometry(QtCore.QRect(140, 20, 111, 31))
        font = QtGui.QFont()
        font.setBold(False)
        font.setWeight(50)
        self.changePriority.setFont(font)
        self.changePriority.setObjectName("changePriority")
        self.changePriority.clicked.connect(changeBSPriority)

        self.retranslateUi(Dialog)
        QtCore.QMetaObject.connectSlotsByName(Dialog)

    def retranslateUi(self, Dialog):
        _translate = QtCore.QCoreApplication.translate
        Dialog.setWindowTitle(_translate("Dialog", "BSUtils"))
        self.pushButton.setText(_translate("Dialog", "Disable ASW"))
        self.changePriority.setText(_translate("Dialog", "Change BS Priority"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    Dialog = QtWidgets.QDialog()
    ui = Ui_Dialog()
    ui.setupUi(Dialog)
    Dialog.show()
    sys.exit(app.exec_())
