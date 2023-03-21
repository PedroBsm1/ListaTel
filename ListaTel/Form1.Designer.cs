namespace ListaTel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.listListaTel = new System.Windows.Forms.ListBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListaTel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(25, 155);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTel.Location = new System.Drawing.Point(25, 228);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(70, 21);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblList.Location = new System.Drawing.Point(447, 131);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(131, 21);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Lista de Telefones";
            this.lblList.Click += new System.EventHandler(this.lblList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(447, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "PEDRO \'S   AGENDA";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(50, 310);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 52);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(470, 310);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 52);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 153);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // listListaTel
            // 
            this.listListaTel.FormattingEnabled = true;
            this.listListaTel.ItemHeight = 15;
            this.listListaTel.Location = new System.Drawing.Point(447, 155);
            this.listListaTel.Name = "listListaTel";
            this.listListaTel.Size = new System.Drawing.Size(286, 94);
            this.listListaTel.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(105, 229);
            this.txtTel.Mask = "(99) 00000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 23);
            this.txtTel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.listListaTel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNome;
        private Label lblTel;
        private Label lblList;
        private Label label4;
        private Button btnIncluir;
        private Button btnListar;
        private TextBox txtNome;
        private ListBox listListaTel;
        private MaskedTextBox txtTel;
    }
}