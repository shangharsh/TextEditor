To Create a Text Editor follow the below steps

Step 1: Create a new form.
Step 2: Add MenuStrip at the top of the form having options like below.
        -New
        -Open
        -Save
        -Exit
Step 3: Add a click event to each option by double-clicking on it.
Step 4: To New
        -Remove the text from the textbox.
        eg: textbox.clear();
Step 5: To Open
        -Use openfiledialog component
        eg: openfiledialog ofd = new openfiledialog();
        -Check openfiledialog's showdialog is equal to the dialogresult.ok or not, if yes
        -use readalltext method to and store the file value to the new variable.
        -assign that variable to the textbox.
        eg: if(openfiledialog.showdialog() == dialogresult.ok){
        string readfile = system.io.file.readalltext(ofd.filename);
        this.txtbox.text = readfile;
        }
Step 6: To Save
        -if the textbox is empty show the message "Enter Text First" else
        -use savefiledialog component
        eg: savefiledialog sfd = new savefiledialog();
        -add file type as below:
        eg: sfd.filter = "Text(*.txt)|*.txt|Word Doc(*.doc)|*.doc";
        -check the savefiledialog's showdialog is equals to dialogresilt.ok then do
        eg: if(savefiledialog.showdialog() == dialogresult.ok){
        string textdoc = this.txtbox.text;
        system.io.file.writealltext(sfd.filename, textdoc);
        txtbox.clear();
        }
Step 7: For Exit
        -use the .close method to close the form.
        eg: this.close();
