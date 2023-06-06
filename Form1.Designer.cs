namespace Testing_Reporteconfigurable
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrossRigth = new System.Windows.Forms.Button();
            this.btnCrossLeft = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 381);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCrossRigth
            // 
            this.btnCrossRigth.Location = new System.Drawing.Point(217, 256);
            this.btnCrossRigth.Name = "btnCrossRigth";
            this.btnCrossRigth.Size = new System.Drawing.Size(86, 40);
            this.btnCrossRigth.TabIndex = 2;
            this.btnCrossRigth.Text = ">>";
            this.btnCrossRigth.UseVisualStyleBackColor = true;
            this.btnCrossRigth.Click += new System.EventHandler(this.btnCrossRigth_Click);
            // 
            // btnCrossLeft
            // 
            this.btnCrossLeft.Location = new System.Drawing.Point(217, 323);
            this.btnCrossLeft.Name = "btnCrossLeft";
            this.btnCrossLeft.Size = new System.Drawing.Size(86, 40);
            this.btnCrossLeft.TabIndex = 2;
            this.btnCrossLeft.Text = "<<";
            this.btnCrossLeft.UseVisualStyleBackColor = true;
            this.btnCrossLeft.Click += new System.EventHandler(this.btnCrossLeft_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(970, 12);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(86, 40);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(311, 145);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(207, 381);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 581);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCrossLeft);
            this.Controls.Add(this.btnCrossRigth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrossRigth;
        private System.Windows.Forms.Button btnCrossLeft;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ListView listView2;
    }
}

