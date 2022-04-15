namespace EZftp
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblADRESSE = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.lblPORT = new System.Windows.Forms.Label();
            this.listBoxSave = new System.Windows.Forms.ListBox();
            this.checkSave = new System.Windows.Forms.CheckBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(159, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Se connecter à un serveur FTP.";
            // 
            // lblADRESSE
            // 
            this.lblADRESSE.AutoSize = true;
            this.lblADRESSE.Location = new System.Drawing.Point(12, 40);
            this.lblADRESSE.Name = "lblADRESSE";
            this.lblADRESSE.Size = new System.Drawing.Size(45, 13);
            this.lblADRESSE.TabIndex = 1;
            this.lblADRESSE.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(12, 56);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(185, 20);
            this.textBoxAdresse.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(203, 56);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // lblPORT
            // 
            this.lblPORT.AutoSize = true;
            this.lblPORT.Location = new System.Drawing.Point(200, 40);
            this.lblPORT.Name = "lblPORT";
            this.lblPORT.Size = new System.Drawing.Size(26, 13);
            this.lblPORT.TabIndex = 4;
            this.lblPORT.Text = "Port";
            // 
            // listBoxSave
            // 
            this.listBoxSave.FormattingEnabled = true;
            this.listBoxSave.Location = new System.Drawing.Point(15, 130);
            this.listBoxSave.Name = "listBoxSave";
            this.listBoxSave.Size = new System.Drawing.Size(258, 69);
            this.listBoxSave.TabIndex = 5;
            this.listBoxSave.SelectedIndexChanged += new System.EventHandler(this.listBoxSave_SelectedIndexChanged);
            // 
            // checkSave
            // 
            this.checkSave.AutoSize = true;
            this.checkSave.Location = new System.Drawing.Point(12, 82);
            this.checkSave.Name = "checkSave";
            this.checkSave.Size = new System.Drawing.Size(140, 17);
            this.checkSave.TabIndex = 6;
            this.checkSave.Text = "Sauvegarder ce serveur";
            this.checkSave.UseVisualStyleBackColor = true;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(12, 114);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(96, 13);
            this.lblSave.TabIndex = 7;
            this.lblSave.Text = "Serveurs saugardé";
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(279, 12);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 202);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "GO !";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(12, 202);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(166, 13);
            this.lblDelete.TabIndex = 9;
            this.lblDelete.TabStop = true;
            this.lblDelete.Text = "Suprimer les serveurs sauvegardé";
            this.lblDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDelete_LinkClicked);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 226);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.checkSave);
            this.Controls.Add(this.listBoxSave);
            this.Controls.Add(this.lblPORT);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.lblADRESSE);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "EZftp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblADRESSE;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label lblPORT;
        private System.Windows.Forms.ListBox listBoxSave;
        private System.Windows.Forms.CheckBox checkSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.LinkLabel lblDelete;
    }
}

