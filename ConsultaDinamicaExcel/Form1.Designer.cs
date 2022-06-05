
namespace ConsultaDinamicaExcel
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
            this.cbo_Busca = new System.Windows.Forms.ComboBox();
            this.txt_Criterio = new System.Windows.Forms.TextBox();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Exibir_Todos = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.label_procurar = new System.Windows.Forms.Label();
            this.btn_importar_excel = new System.Windows.Forms.Button();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_arquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Busca
            // 
            this.cbo_Busca.FormattingEnabled = true;
            this.cbo_Busca.Location = new System.Drawing.Point(104, 10);
            this.cbo_Busca.Name = "cbo_Busca";
            this.cbo_Busca.Size = new System.Drawing.Size(230, 28);
            this.cbo_Busca.TabIndex = 0;
            // 
            // txt_Criterio
            // 
            this.txt_Criterio.Location = new System.Drawing.Point(340, 10);
            this.txt_Criterio.Name = "txt_Criterio";
            this.txt_Criterio.Size = new System.Drawing.Size(144, 27);
            this.txt_Criterio.TabIndex = 1;
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Procurar.Location = new System.Drawing.Point(490, 10);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(120, 29);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = false;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click_1);
            // 
            // btn_Exibir_Todos
            // 
            this.btn_Exibir_Todos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Exibir_Todos.Location = new System.Drawing.Point(616, 11);
            this.btn_Exibir_Todos.Name = "btn_Exibir_Todos";
            this.btn_Exibir_Todos.Size = new System.Drawing.Size(180, 29);
            this.btn_Exibir_Todos.TabIndex = 3;
            this.btn_Exibir_Todos.Text = "Exibir Todos";
            this.btn_Exibir_Todos.UseVisualStyleBackColor = false;
            this.btn_Exibir_Todos.Click += new System.EventHandler(this.btn_Exibir_Todos_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(4, 46);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.RowHeadersWidth = 51;
            this.dgv_dados.RowTemplate.Height = 29;
            this.dgv_dados.Size = new System.Drawing.Size(792, 322);
            this.dgv_dados.TabIndex = 4;
            // 
            // label_procurar
            // 
            this.label_procurar.AutoSize = true;
            this.label_procurar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_procurar.Location = new System.Drawing.Point(4, 11);
            this.label_procurar.Name = "label_procurar";
            this.label_procurar.Size = new System.Drawing.Size(94, 20);
            this.label_procurar.TabIndex = 5;
            this.label_procurar.Text = "Procurar por:";
            // 
            // btn_importar_excel
            // 
            this.btn_importar_excel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_importar_excel.Location = new System.Drawing.Point(490, 381);
            this.btn_importar_excel.Name = "btn_importar_excel";
            this.btn_importar_excel.Size = new System.Drawing.Size(120, 29);
            this.btn_importar_excel.TabIndex = 6;
            this.btn_importar_excel.Text = "Importar Excel";
            this.btn_importar_excel.UseVisualStyleBackColor = false;
            this.btn_importar_excel.Click += new System.EventHandler(this.btn_importar_excel_Click);
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_numero_registros.Location = new System.Drawing.Point(685, 385);
            this.label_numero_registros.Margin = new System.Windows.Forms.Padding(3);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(111, 20);
            this.label_numero_registros.TabIndex = 7;
            this.label_numero_registros.Text = "N° de registros:";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // btn_arquivo
            // 
            this.btn_arquivo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_arquivo.Location = new System.Drawing.Point(4, 381);
            this.btn_arquivo.Name = "btn_arquivo";
            this.btn_arquivo.Size = new System.Drawing.Size(480, 29);
            this.btn_arquivo.TabIndex = 9;
            this.btn_arquivo.UseVisualStyleBackColor = false;
            this.btn_arquivo.Click += new System.EventHandler(this.btn_arquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(827, 434);
            this.Controls.Add(this.btn_arquivo);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.btn_importar_excel);
            this.Controls.Add(this.label_procurar);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.btn_Exibir_Todos);
            this.Controls.Add(this.btn_Procurar);
            this.Controls.Add(this.txt_Criterio);
            this.Controls.Add(this.cbo_Busca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Dinâmica";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Busca;
        private System.Windows.Forms.TextBox txt_Criterio;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Exibir_Todos;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Label label_procurar;
        private System.Windows.Forms.Button btn_importar_excel;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btn_arquivo;
    }
}