namespace AgendaDeRecursos
{
    partial class AdmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmAgenda));
            this.Agenda = new System.Windows.Forms.Calendar.Calendar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vTotalAgenda = new System.Windows.Forms.Label();
            this.vTotalLista = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vId = new System.Windows.Forms.Label();
            this.vTurno = new System.Windows.Forms.Label();
            this.vCursoDivision = new System.Windows.Forms.Label();
            this.vGrupo = new System.Windows.Forms.Label();
            this.vPlanEstudios = new System.Windows.Forms.Label();
            this.vCurso = new System.Windows.Forms.Label();
            this.vUnidadEducativa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVigenciaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtVigenciaHasta = new System.Windows.Forms.DateTimePicker();
            this.vAmbiente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btListaAmbientes = new System.Windows.Forms.Button();
            this.Agenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agenda
            // 
            this.Agenda.AutoScroll = true;
            this.Agenda.BackColor = System.Drawing.SystemColors.Control;
            this.Agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Agenda.Controls.Add(this.trackBar1);
            this.Agenda.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.Agenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Agenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("09:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("18:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("09:00:00");
            this.Agenda.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5,
        calendarHighlightRange6,
        calendarHighlightRange7};
            this.Agenda.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Agenda.Location = new System.Drawing.Point(12, 130);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(831, 425);
            this.Agenda.TabIndex = 0;
            this.Agenda.Text = "Agenda";
            this.Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            this.Agenda.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.Agenda_LoadItems);
            this.Agenda.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.Agenda_ItemCreated);
            this.Agenda.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.Agenda_ItemDeleted);
            this.Agenda.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.Agenda_ItemDatesChanged);
            this.Agenda.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.itemdobleclick);
            this.Agenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(59, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.vScroll);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Items Agenda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Items Lista:";
            // 
            // vTotalAgenda
            // 
            this.vTotalAgenda.AutoSize = true;
            this.vTotalAgenda.Location = new System.Drawing.Point(167, 579);
            this.vTotalAgenda.Name = "vTotalAgenda";
            this.vTotalAgenda.Size = new System.Drawing.Size(87, 13);
            this.vTotalAgenda.TabIndex = 20;
            this.vTotalAgenda.Text = "Total Items Lista:";
            // 
            // vTotalLista
            // 
            this.vTotalLista.AutoSize = true;
            this.vTotalLista.Location = new System.Drawing.Point(426, 579);
            this.vTotalLista.Name = "vTotalLista";
            this.vTotalLista.Size = new System.Drawing.Size(87, 13);
            this.vTotalLista.TabIndex = 21;
            this.vTotalLista.Text = "Total Items Lista:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 500;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vId);
            this.groupBox1.Controls.Add(this.vTurno);
            this.groupBox1.Controls.Add(this.vCursoDivision);
            this.groupBox1.Controls.Add(this.vGrupo);
            this.groupBox1.Controls.Add(this.vPlanEstudios);
            this.groupBox1.Controls.Add(this.vCurso);
            this.groupBox1.Controls.Add(this.vUnidadEducativa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 103);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instancia de Grupo";
            // 
            // vId
            // 
            this.vId.AutoSize = true;
            this.vId.Location = new System.Drawing.Point(214, 13);
            this.vId.Name = "vId";
            this.vId.Size = new System.Drawing.Size(25, 13);
            this.vId.TabIndex = 12;
            this.vId.Text = "VID";
            this.vId.Visible = false;
            // 
            // vTurno
            // 
            this.vTurno.AutoSize = true;
            this.vTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vTurno.Location = new System.Drawing.Point(107, 69);
            this.vTurno.Name = "vTurno";
            this.vTurno.Size = new System.Drawing.Size(44, 13);
            this.vTurno.TabIndex = 11;
            this.vTurno.Text = "Turno:";
            // 
            // vCursoDivision
            // 
            this.vCursoDivision.AutoSize = true;
            this.vCursoDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCursoDivision.Location = new System.Drawing.Point(387, 68);
            this.vCursoDivision.Name = "vCursoDivision";
            this.vCursoDivision.Size = new System.Drawing.Size(108, 13);
            this.vCursoDivision.TabIndex = 10;
            this.vCursoDivision.Text = "División/Sección:";
            // 
            // vGrupo
            // 
            this.vGrupo.AutoSize = true;
            this.vGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGrupo.Location = new System.Drawing.Point(384, 26);
            this.vGrupo.Name = "vGrupo";
            this.vGrupo.Size = new System.Drawing.Size(45, 13);
            this.vGrupo.TabIndex = 8;
            this.vGrupo.Text = "Grupo:";
            // 
            // vPlanEstudios
            // 
            this.vPlanEstudios.AutoSize = true;
            this.vPlanEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPlanEstudios.Location = new System.Drawing.Point(107, 48);
            this.vPlanEstudios.Name = "vPlanEstudios";
            this.vPlanEstudios.Size = new System.Drawing.Size(106, 13);
            this.vPlanEstudios.TabIndex = 7;
            this.vPlanEstudios.Text = "Plan de Estudios:";
            // 
            // vCurso
            // 
            this.vCurso.AutoSize = true;
            this.vCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCurso.Location = new System.Drawing.Point(384, 48);
            this.vCurso.Name = "vCurso";
            this.vCurso.Size = new System.Drawing.Size(43, 13);
            this.vCurso.TabIndex = 9;
            this.vCurso.Text = "Curso:";
            // 
            // vUnidadEducativa
            // 
            this.vUnidadEducativa.AutoSize = true;
            this.vUnidadEducativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vUnidadEducativa.Location = new System.Drawing.Point(107, 26);
            this.vUnidadEducativa.Name = "vUnidadEducativa";
            this.vUnidadEducativa.Size = new System.Drawing.Size(112, 13);
            this.vUnidadEducativa.TabIndex = 6;
            this.vUnidadEducativa.Text = "Unidad Educativa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Plan de Estudios:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Grupo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "División/Sección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Curso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Unidad Educativa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aula por defecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vigencia desde:";
            // 
            // dtVigenciaDesde
            // 
            this.dtVigenciaDesde.Location = new System.Drawing.Point(611, 54);
            this.dtVigenciaDesde.Name = "dtVigenciaDesde";
            this.dtVigenciaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtVigenciaDesde.TabIndex = 6;
            this.dtVigenciaDesde.ValueChanged += new System.EventHandler(this.dtVigenciaDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vigencia hasta:";
            // 
            // dtVigenciaHasta
            // 
            this.dtVigenciaHasta.Location = new System.Drawing.Point(611, 77);
            this.dtVigenciaHasta.Name = "dtVigenciaHasta";
            this.dtVigenciaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtVigenciaHasta.TabIndex = 17;
            this.dtVigenciaHasta.ValueChanged += new System.EventHandler(this.dtVigenciaHasta_ValueChanged);
            // 
            // vAmbiente
            // 
            this.vAmbiente.Location = new System.Drawing.Point(613, 29);
            this.vAmbiente.Name = "vAmbiente";
            this.vAmbiente.ReadOnly = true;
            this.vAmbiente.Size = new System.Drawing.Size(149, 20);
            this.vAmbiente.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btListaAmbientes);
            this.groupBox2.Location = new System.Drawing.Point(502, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 103);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración Agenda";
            // 
            // btListaAmbientes
            // 
            this.btListaAmbientes.Location = new System.Drawing.Point(284, 14);
            this.btListaAmbientes.Name = "btListaAmbientes";
            this.btListaAmbientes.Size = new System.Drawing.Size(25, 23);
            this.btListaAmbientes.TabIndex = 25;
            this.btListaAmbientes.Text = "...";
            this.btListaAmbientes.UseVisualStyleBackColor = true;
            this.btListaAmbientes.Click += new System.EventHandler(this.btListaAmbientes_Click);
            // 
            // AdmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 611);
            this.Controls.Add(this.vAmbiente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vTotalLista);
            this.Controls.Add(this.vTotalAgenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtVigenciaHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtVigenciaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.groupBox2);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "AdmAgenda";
            this.Text = "AdmAgenda";
            this.Load += new System.EventHandler(this.AdmAgenda_Load);
            this.Agenda.ResumeLayout(false);
            this.Agenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Calendar.Calendar Agenda;
        private System.Windows.Forms.TrackBar trackBar1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label vTotalLista;
        private System.Windows.Forms.Label vTotalAgenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vId;
        private System.Windows.Forms.Label vTurno;
        private System.Windows.Forms.Label vCursoDivision;
        private System.Windows.Forms.Label vGrupo;
        private System.Windows.Forms.Label vPlanEstudios;
        private System.Windows.Forms.Label vCurso;
        private System.Windows.Forms.Label vUnidadEducativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vAmbiente;
        private System.Windows.Forms.DateTimePicker dtVigenciaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtVigenciaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btListaAmbientes;



    }
}