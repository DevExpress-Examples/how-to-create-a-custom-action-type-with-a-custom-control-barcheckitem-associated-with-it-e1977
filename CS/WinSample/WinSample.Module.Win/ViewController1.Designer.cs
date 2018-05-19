namespace WinSample.Module.Win {
    partial class ViewController1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new WinSample.Module.Win.CheckableSimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "Filter";
            this.simpleAction1.Checked = false;
            this.simpleAction1.Id = "601213b0-c5b4-4136-95a2-eea9b2d6e498";
            this.simpleAction1.Tag = null;
            this.simpleAction1.TypeOfView = null;
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);

        }

        #endregion

        private CheckableSimpleAction simpleAction1;
    }
}
