namespace Mag_SuitBuilder.Spells
{
	partial class EnchantmentSelectorControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			defaultsComboBox = new System.Windows.Forms.ComboBox();
			cmdClear = new System.Windows.Forms.Button();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			ColAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColProtections = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColMagics = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColPrimaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColSecondaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColDefenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColTinkCraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
			lblEights = new System.Windows.Forms.Label();
			lblSevens = new System.Windows.Forms.Label();
			lblSixes = new System.Windows.Forms.Label();
			lblLoadDefaults = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// defaultsComboBox
			// 
			defaultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			defaultsComboBox.FormattingEnabled = true;
			defaultsComboBox.Items.AddRange(new object[] { "", "Finesse", "Generic", "Heavy", "Light", "Missile", "Tinker", "Two Hand", "Void", "War" });
			defaultsComboBox.Location = new System.Drawing.Point(91, 3);
			defaultsComboBox.Name = "defaultsComboBox";
			defaultsComboBox.Size = new System.Drawing.Size(154, 23);
			defaultsComboBox.TabIndex = 1;
			defaultsComboBox.SelectedIndexChanged += defaultsComboBox_SelectedIndexChanged;
			// 
			// cmdClear
			// 
			cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			cmdClear.Location = new System.Drawing.Point(518, 3);
			cmdClear.Name = "cmdClear";
			cmdClear.Size = new System.Drawing.Size(64, 23);
			cmdClear.TabIndex = 2;
			cmdClear.Text = "Clear";
			cmdClear.UseVisualStyleBackColor = true;
			cmdClear.Click += cmdClear_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColAttributes, ColProtections, ColMagics, ColPrimaries, ColSecondaries, ColDefenses, ColTinkCraft });
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.Location = new System.Drawing.Point(0, 33);
			dataGridView1.Margin = new System.Windows.Forms.Padding(0);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 20;
			dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			dataGridView1.Size = new System.Drawing.Size(585, 143);
			dataGridView1.TabIndex = 3;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellDoubleClick += dataGridView1_CellClick;
			// 
			// ColAttributes
			// 
			ColAttributes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColAttributes.HeaderText = "ColAttributes";
			ColAttributes.Name = "ColAttributes";
			ColAttributes.ReadOnly = true;
			ColAttributes.Width = 5;
			// 
			// ColProtections
			// 
			ColProtections.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColProtections.HeaderText = "ColProtections";
			ColProtections.Name = "ColProtections";
			ColProtections.ReadOnly = true;
			ColProtections.Width = 5;
			// 
			// ColMagics
			// 
			ColMagics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColMagics.HeaderText = "ColMagics";
			ColMagics.Name = "ColMagics";
			ColMagics.ReadOnly = true;
			ColMagics.Width = 5;
			// 
			// ColPrimaries
			// 
			ColPrimaries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColPrimaries.HeaderText = "ColPrimaries";
			ColPrimaries.Name = "ColPrimaries";
			ColPrimaries.ReadOnly = true;
			ColPrimaries.Width = 5;
			// 
			// ColSecondaries
			// 
			ColSecondaries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColSecondaries.HeaderText = "ColSecondaries";
			ColSecondaries.Name = "ColSecondaries";
			ColSecondaries.ReadOnly = true;
			ColSecondaries.Width = 5;
			// 
			// ColDefenses
			// 
			ColDefenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColDefenses.HeaderText = "ColDefenses";
			ColDefenses.Name = "ColDefenses";
			ColDefenses.ReadOnly = true;
			ColDefenses.Width = 5;
			// 
			// ColTinkCraft
			// 
			ColTinkCraft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColTinkCraft.HeaderText = "ColTinkCraft";
			ColTinkCraft.Name = "ColTinkCraft";
			ColTinkCraft.ReadOnly = true;
			ColTinkCraft.Width = 5;
			// 
			// lblEights
			// 
			lblEights.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblEights.AutoSize = true;
			lblEights.BackColor = System.Drawing.Color.DarkOrange;
			lblEights.Location = new System.Drawing.Point(3, 179);
			lblEights.Name = "lblEights";
			lblEights.Size = new System.Drawing.Size(60, 15);
			lblEights.TabIndex = 4;
			lblEights.Text = "- Level 8s -";
			// 
			// lblSevens
			// 
			lblSevens.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblSevens.AutoSize = true;
			lblSevens.BackColor = System.Drawing.Color.LightGreen;
			lblSevens.Location = new System.Drawing.Point(69, 179);
			lblSevens.Name = "lblSevens";
			lblSevens.Size = new System.Drawing.Size(55, 15);
			lblSevens.TabIndex = 7;
			lblSevens.Text = "- Level 7s -";
			// 
			// lblSixes
			// 
			lblSixes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblSixes.AutoSize = true;
			lblSixes.BackColor = System.Drawing.Color.Pink;
			lblSixes.Location = new System.Drawing.Point(130, 179);
			lblSixes.Name = "lblSixes";
			lblSixes.Size = new System.Drawing.Size(64, 15);
			lblSixes.TabIndex = 6;
			lblSixes.Text = "- Level 6s -";
			// 
			// lblLoadDefaults
			// 
			lblLoadDefaults.AutoSize = true;
			lblLoadDefaults.Location = new System.Drawing.Point(3, 7);
			lblLoadDefaults.Name = "lblLoadDefaults";
			lblLoadDefaults.Size = new System.Drawing.Size(82, 15);
			lblLoadDefaults.TabIndex = 8;
			lblLoadDefaults.Text = "Load Defaults:";
			// 
			// CantripSelectorControl
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(lblLoadDefaults);
			Controls.Add(lblSixes);
			Controls.Add(lblSevens);
			Controls.Add(lblEights);
			Controls.Add(dataGridView1);
			Controls.Add(cmdClear);
			Controls.Add(defaultsComboBox);
			Name = "CantripSelectorControl";
			Size = new System.Drawing.Size(585, 197);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.ComboBox defaultsComboBox;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColAttributes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColProtections;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColMagics;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPrimaries;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColSecondaries;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDefenses;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTinkCraft;
		private System.Windows.Forms.Label lblEights;
		private System.Windows.Forms.Label lblSevens;
		private System.Windows.Forms.Label lblSixes;
		private System.Windows.Forms.Label lblLoadDefaults;
	}
}
