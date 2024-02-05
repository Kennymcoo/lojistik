namespace abp.Views
{
    partial class AllList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewAllResult = new ListView();
            ButtonForAll = new Button();
            SuspendLayout();
            // 
            // listViewAllResult
            // 
            listViewAllResult.Location = new Point(391, 55);
            listViewAllResult.Name = "listViewAllResult";
            listViewAllResult.Size = new Size(686, 484);
            listViewAllResult.TabIndex = 0;
            listViewAllResult.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonForAll
            // 
            ButtonForAll.Location = new Point(136, 257);
            ButtonForAll.Name = "ButtonForAll";
            ButtonForAll.Size = new Size(75, 23);
            ButtonForAll.TabIndex = 1;
            ButtonForAll.Text = "Show";
            ButtonForAll.UseVisualStyleBackColor = true;
            ButtonForAll.Click += ButtonForAll_Click;
            // 
            // AllList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 589);
            Controls.Add(ButtonForAll);
            Controls.Add(listViewAllResult);
            Name = "AllList";
            Text = "AllList";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAllResult;
        private Button ButtonForAll;
    }
}