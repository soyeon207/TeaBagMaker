namespace TeaBagMaker
{
    partial class Form1
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
            this.CB = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(13, 13);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(296, 20);
            this.CB.TabIndex = 0;
            this.CB.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(13, 40);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(296, 26);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기!";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "timer";
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timelbl.Location = new System.Drawing.Point(11, 69);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(50, 14);
            this.timelbl.TabIndex = 2;
            this.timelbl.Text = "시간 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(199, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "2019-05-27 3506 박소연";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.CB);
            this.Name = "Form1";
            this.Text = "TeaBagMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label2;
    }
}

