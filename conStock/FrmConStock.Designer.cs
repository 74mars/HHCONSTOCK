namespace conStock
{
    partial class FrmConStock
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConStock));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.accdionCtl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accMenuIOput = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accMenuView = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.userID = new System.Windows.Forms.ToolStripStatusLabel();
            this.space1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userName = new System.Windows.Forms.ToolStripStatusLabel();
            this.space2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.whID = new System.Windows.Forms.ToolStripStatusLabel();
            this.space3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.whName = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.todayDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdionCtl)).BeginInit();
            this.mainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mainStatus, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1708, 994);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Controls.Add(this.xtraTabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.accdionCtl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1702, 968);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabControl1.Location = new System.Drawing.Point(238, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1464, 968);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.HeaderButtonClick += new DevExpress.XtraTab.ViewInfo.HeaderButtonEventHandler(this.xtraTabControl1_HeaderButtonClick);
            // 
            // accdionCtl
            // 
            this.accdionCtl.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Simple;
            this.accdionCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accdionCtl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accMenuIOput,
            this.accMenuView});
            this.accdionCtl.Location = new System.Drawing.Point(3, 3);
            this.accdionCtl.Name = "accdionCtl";
            this.accdionCtl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accdionCtl.Size = new System.Drawing.Size(232, 962);
            this.accdionCtl.TabIndex = 0;
            this.accdionCtl.Text = "accordionControl1";
            // 
            // accMenuIOput
            // 
            this.accMenuIOput.Appearance.Hovered.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuIOput.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accMenuIOput.Appearance.Hovered.Options.UseFont = true;
            this.accMenuIOput.Appearance.Hovered.Options.UseForeColor = true;
            this.accMenuIOput.Appearance.Normal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuIOput.Appearance.Normal.ForeColor = System.Drawing.Color.Teal;
            this.accMenuIOput.Appearance.Normal.Options.UseFont = true;
            this.accMenuIOput.Appearance.Normal.Options.UseForeColor = true;
            this.accMenuIOput.Appearance.Pressed.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuIOput.Appearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accMenuIOput.Appearance.Pressed.Options.UseFont = true;
            this.accMenuIOput.Appearance.Pressed.Options.UseForeColor = true;
            this.accMenuIOput.Expanded = true;
            this.accMenuIOput.Name = "accMenuIOput";
            this.accMenuIOput.Text = "STOCK IN/OUT";
            // 
            // accMenuView
            // 
            this.accMenuView.Appearance.Hovered.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuView.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accMenuView.Appearance.Hovered.Options.UseFont = true;
            this.accMenuView.Appearance.Hovered.Options.UseForeColor = true;
            this.accMenuView.Appearance.Normal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuView.Appearance.Normal.ForeColor = System.Drawing.Color.Teal;
            this.accMenuView.Appearance.Normal.Options.UseFont = true;
            this.accMenuView.Appearance.Normal.Options.UseForeColor = true;
            this.accMenuView.Appearance.Pressed.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenuView.Appearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accMenuView.Appearance.Pressed.Options.UseFont = true;
            this.accMenuView.Appearance.Pressed.Options.UseForeColor = true;
            this.accMenuView.Name = "accMenuView";
            this.accMenuView.Text = "STOCK VIEW";
            // 
            // mainStatus
            // 
            this.mainStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userID,
            this.space1,
            this.userName,
            this.space2,
            this.whID,
            this.space3,
            this.whName,
            this.spaceSpring,
            this.todayDate});
            this.mainStatus.Location = new System.Drawing.Point(0, 974);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(1708, 20);
            this.mainStatus.TabIndex = 2;
            this.mainStatus.Text = "statusStrip1";
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(57, 15);
            this.userID.Text = "User ID";
            // 
            // space1
            // 
            this.space1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(24, 15);
            this.space1.Text = "     ";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(80, 15);
            this.userName.Text = "user Name";
            // 
            // space2
            // 
            this.space2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(28, 15);
            this.space2.Text = "     ";
            // 
            // whID
            // 
            this.whID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whID.Name = "whID";
            this.whID.Size = new System.Drawing.Size(101, 15);
            this.whID.Text = "Warehouse ID";
            // 
            // space3
            // 
            this.space3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space3.Name = "space3";
            this.space3.Size = new System.Drawing.Size(28, 15);
            this.space3.Text = "     ";
            // 
            // whName
            // 
            this.whName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whName.Name = "whName";
            this.whName.Size = new System.Drawing.Size(126, 15);
            this.whName.Text = "Warehouse Name";
            // 
            // spaceSpring
            // 
            this.spaceSpring.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceSpring.Name = "spaceSpring";
            this.spaceSpring.Size = new System.Drawing.Size(1129, 15);
            this.spaceSpring.Spring = true;
            // 
            // todayDate
            // 
            this.todayDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(81, 15);
            this.todayDate.Text = "Today Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmConStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 994);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmConStock";
            this.Text = "Warehouse Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConStock_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdionCtl)).EndInit();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraBars.Navigation.AccordionControl accdionCtl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accMenuIOput;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accMenuView;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel userID;
        private System.Windows.Forms.ToolStripStatusLabel space1;
        private System.Windows.Forms.ToolStripStatusLabel userName;
        private System.Windows.Forms.ToolStripStatusLabel space2;
        private System.Windows.Forms.ToolStripStatusLabel whID;
        private System.Windows.Forms.ToolStripStatusLabel space3;
        private System.Windows.Forms.ToolStripStatusLabel whName;
        private System.Windows.Forms.ToolStripStatusLabel spaceSpring;
        private System.Windows.Forms.ToolStripStatusLabel todayDate;
        private System.Windows.Forms.Timer timer1;
    }
}

