
namespace QBuild
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
            this.Display = new System.Windows.Forms.GroupBox();
            this.CurrentNodeLabel = new System.Windows.Forms.Label();
            this.FullPathLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.dataTreeView = new System.Windows.Forms.TreeView();
            this.populateDataButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Display.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Controls.Add(this.CurrentNodeLabel);
            this.Display.Controls.Add(this.FullPathLabel);
            this.Display.Controls.Add(this.currentLabel);
            this.Display.Controls.Add(this.PathLabel);
            this.Display.Controls.Add(this.dataTreeView);
            this.Display.Controls.Add(this.populateDataButton);
            this.Display.Controls.Add(this.exitButton);
            this.Display.Location = new System.Drawing.Point(14, 47);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Name = "Display";
            this.Display.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Size = new System.Drawing.Size(887, 233);
            this.Display.TabIndex = 0;
            this.Display.TabStop = false;
            this.Display.Text = " ";
            // 
            // CurrentNodeLabel
            // 
            this.CurrentNodeLabel.AutoSize = true;
            this.CurrentNodeLabel.ForeColor = System.Drawing.Color.Lime;
            this.CurrentNodeLabel.Location = new System.Drawing.Point(497, 80);
            this.CurrentNodeLabel.Name = "CurrentNodeLabel";
            this.CurrentNodeLabel.Size = new System.Drawing.Size(0, 20);
            this.CurrentNodeLabel.TabIndex = 6;
            // 
            // FullPathLabel
            // 
            this.FullPathLabel.AutoSize = true;
            this.FullPathLabel.ForeColor = System.Drawing.Color.Red;
            this.FullPathLabel.Location = new System.Drawing.Point(528, 29);
            this.FullPathLabel.Name = "FullPathLabel";
            this.FullPathLabel.Size = new System.Drawing.Size(0, 20);
            this.FullPathLabel.TabIndex = 5;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentLabel.Location = new System.Drawing.Point(349, 80);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(89, 20);
            this.currentLabel.TabIndex = 4;
            this.currentLabel.Text = "Current Part:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.ForeColor = System.Drawing.Color.Red;
            this.PathLabel.Location = new System.Drawing.Point(349, 29);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(120, 20);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Parent Child Part:";
            // 
            // dataTreeView
            // 
            this.dataTreeView.Location = new System.Drawing.Point(33, 29);
            this.dataTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataTreeView.Name = "dataTreeView";
            this.dataTreeView.Size = new System.Drawing.Size(267, 195);
            this.dataTreeView.TabIndex = 2;
            this.dataTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataTreeView_AfterSelect);
            // 
            // populateDataButton
            // 
            this.populateDataButton.Location = new System.Drawing.Point(349, 134);
            this.populateDataButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.populateDataButton.Name = "populateDataButton";
            this.populateDataButton.Size = new System.Drawing.Size(198, 31);
            this.populateDataButton.TabIndex = 1;
            this.populateDataButton.Text = "Populate Data In Tree";
            this.populateDataButton.UseVisualStyleBackColor = true;
            this.populateDataButton.Click += new System.EventHandler(this.populateDataButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(349, 173);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(198, 31);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit From Application";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Data
            // 
            this.Data.Controls.Add(this.dataGridView1);
            this.Data.Location = new System.Drawing.Point(14, 307);
            this.Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Data.Size = new System.Drawing.Size(887, 277);
            this.Data.TabIndex = 1;
            this.Data.TabStop = false;
            this.Data.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = " Testing Functionality for Tree and DataGrid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "QBulid";
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Display;
        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.TreeView dataTreeView;
        private System.Windows.Forms.Button populateDataButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label CurrentNodeLabel;
        private System.Windows.Forms.Label FullPathLabel;
        private System.Windows.Forms.Label label1;
    }
}

