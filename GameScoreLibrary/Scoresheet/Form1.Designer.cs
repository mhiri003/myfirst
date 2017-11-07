namespace Scoresheet
{
    partial class Form1
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
            this.btnGenGameList = new System.Windows.Forms.Button();
            this.btnSerializeList = new System.Windows.Forms.Button();
            this.lstGames = new System.Windows.Forms.ListBox();
            this.btnDeserializeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenGameList
            // 
            this.btnGenGameList.Location = new System.Drawing.Point(69, 53);
            this.btnGenGameList.Name = "btnGenGameList";
            this.btnGenGameList.Size = new System.Drawing.Size(80, 23);
            this.btnGenGameList.TabIndex = 0;
            this.btnGenGameList.Text = "Generate List";
            this.btnGenGameList.UseVisualStyleBackColor = true;
            this.btnGenGameList.Click += new System.EventHandler(this.btnGenGameList_Click);
            // 
            // btnSerializeList
            // 
            this.btnSerializeList.Location = new System.Drawing.Point(69, 90);
            this.btnSerializeList.Name = "btnSerializeList";
            this.btnSerializeList.Size = new System.Drawing.Size(75, 23);
            this.btnSerializeList.TabIndex = 1;
            this.btnSerializeList.Text = "Serialize List";
            this.btnSerializeList.UseVisualStyleBackColor = true;
            this.btnSerializeList.Click += new System.EventHandler(this.btnSerializeList_Click);
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(168, 12);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(246, 173);
            this.lstGames.TabIndex = 2;
            // 
            // btnDeserializeList
            // 
            this.btnDeserializeList.Location = new System.Drawing.Point(69, 127);
            this.btnDeserializeList.Name = "btnDeserializeList";
            this.btnDeserializeList.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializeList.TabIndex = 3;
            this.btnDeserializeList.Text = "Deserialize List";
            this.btnDeserializeList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 205);
            this.Controls.Add(this.btnDeserializeList);
            this.Controls.Add(this.lstGames);
            this.Controls.Add(this.btnSerializeList);
            this.Controls.Add(this.btnGenGameList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenGameList;
        private System.Windows.Forms.Button btnSerializeList;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button btnDeserializeList;
    }
}

