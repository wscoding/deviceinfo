// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// Partial Copyright (C) Michael Möller <mmoeller@openhardwaremonitor.org> and Contributors.
// All Rights Reserved.

namespace LibreHardwareMonitor.UI
{
    sealed partial class MainForm
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
            this.sensor = new Aga.Controls.Tree.TreeColumn();
            this.value = new Aga.Controls.Tree.TreeColumn();
            this.min = new Aga.Controls.Tree.TreeColumn();
            this.max = new Aga.Controls.Tree.TreeColumn();
            this.nodeImage = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this.nodeTextBoxText = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxValue = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxMin = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxMax = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanControllerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMinMaxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPlotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.hiddenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gadgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.columnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.temperatureUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitPlotPanelScalingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.logSensorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingIntervalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIntervalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorValuesTimeWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.webMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runWebServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverPortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authWebServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundUpdater = new System.ComponentModel.BackgroundWorker();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.其他待补充ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new LibreHardwareMonitor.UI.SplitContainerAdv();
            this.treeView = new Aga.Controls.Tree.TreeViewAdv();
            this.celsiusMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.fahrenheitMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.plotWindowMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.plotBottomMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.plotRightMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.splitPanelPercentageScalingMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.splitPanelFixedPlotScalingMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.splitPanelFixedSensorScalingMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log1sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log2sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log5sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log10sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log30sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log1minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log2minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log5minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log10minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log30minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log1hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log2hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.log6hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval250msMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval500msMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval1sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval2sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval5sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.updateInterval10sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow30sMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow1minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow2minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow5minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow10minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow30minMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow1hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow2hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow6hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow12hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.timeWindow24hMenuItem = new LibreHardwareMonitor.UI.ToolStripRadioButtonMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensor
            // 
            this.sensor.Header = "Sensor";
            this.sensor.SortOrder = System.Windows.Forms.SortOrder.None;
            this.sensor.TooltipText = null;
            this.sensor.Width = 250;
            // 
            // value
            // 
            this.value.Header = "Value";
            this.value.SortOrder = System.Windows.Forms.SortOrder.None;
            this.value.TooltipText = null;
            this.value.Width = 100;
            // 
            // min
            // 
            this.min.Header = "Min";
            this.min.SortOrder = System.Windows.Forms.SortOrder.None;
            this.min.TooltipText = null;
            this.min.Width = 100;
            // 
            // max
            // 
            this.max.Header = "Max";
            this.max.SortOrder = System.Windows.Forms.SortOrder.None;
            this.max.TooltipText = null;
            this.max.Width = 100;
            // 
            // nodeImage
            // 
            this.nodeImage.DataPropertyName = "Image";
            this.nodeImage.LeftMargin = 1;
            this.nodeImage.ParentColumn = this.sensor;
            this.nodeImage.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Fit;
            // 
            // nodeCheckBox
            // 
            this.nodeCheckBox.DataPropertyName = "Plot";
            this.nodeCheckBox.EditEnabled = true;
            this.nodeCheckBox.LeftMargin = 3;
            this.nodeCheckBox.ParentColumn = this.sensor;
            // 
            // nodeTextBoxText
            // 
            this.nodeTextBoxText.DataPropertyName = "Text";
            this.nodeTextBoxText.EditEnabled = true;
            this.nodeTextBoxText.IncrementalSearchEnabled = true;
            this.nodeTextBoxText.LeftMargin = 3;
            this.nodeTextBoxText.ParentColumn = this.sensor;
            this.nodeTextBoxText.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxText.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxValue
            // 
            this.nodeTextBoxValue.DataPropertyName = "Value";
            this.nodeTextBoxValue.IncrementalSearchEnabled = true;
            this.nodeTextBoxValue.LeftMargin = 3;
            this.nodeTextBoxValue.ParentColumn = this.value;
            this.nodeTextBoxValue.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxValue.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMin
            // 
            this.nodeTextBoxMin.DataPropertyName = "Min";
            this.nodeTextBoxMin.IncrementalSearchEnabled = true;
            this.nodeTextBoxMin.LeftMargin = 3;
            this.nodeTextBoxMin.ParentColumn = this.min;
            this.nodeTextBoxMin.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxMin.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMax
            // 
            this.nodeTextBoxMax.DataPropertyName = "Max";
            this.nodeTextBoxMax.IncrementalSearchEnabled = true;
            this.nodeTextBoxMax.LeftMargin = 3;
            this.nodeTextBoxMax.ParentColumn = this.max;
            this.nodeTextBoxMax.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxMax.UseCompatibleTextRendering = true;
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.optionsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(627, 32);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReportMenuItem,
            this.MenuItem2,
            this.resetMenuItem,
            this.menuItem5,
            this.menuItem6,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(62, 28);
            this.fileMenuItem.Text = "文件";
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click_1);
            // 
            // saveReportMenuItem
            // 
            this.saveReportMenuItem.Name = "saveReportMenuItem";
            this.saveReportMenuItem.Size = new System.Drawing.Size(182, 34);
            this.saveReportMenuItem.Text = "保存日志";
            this.saveReportMenuItem.Click += new System.EventHandler(this.SaveReportMenuItem_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(182, 34);
            this.resetMenuItem.Text = "还原";
            this.resetMenuItem.Click += new System.EventHandler(this.ResetClick);
            // 
            // menuItem5
            // 
            this.menuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainboardMenuItem,
            this.cpuMenuItem,
            this.ramMenuItem,
            this.gpuMenuItem,
            this.fanControllerMenuItem,
            this.hddMenuItem,
            this.nicMenuItem,
            this.psuMenuItem,
            this.batteryMenuItem});
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(182, 34);
            this.menuItem5.Text = "硬件";
            // 
            // mainboardMenuItem
            // 
            this.mainboardMenuItem.Name = "mainboardMenuItem";
            this.mainboardMenuItem.Size = new System.Drawing.Size(237, 34);
            this.mainboardMenuItem.Text = "主板";
            // 
            // cpuMenuItem
            // 
            this.cpuMenuItem.Name = "cpuMenuItem";
            this.cpuMenuItem.Size = new System.Drawing.Size(237, 34);
            this.cpuMenuItem.Text = "CPU(处理器)";
            // 
            // ramMenuItem
            // 
            this.ramMenuItem.Name = "ramMenuItem";
            this.ramMenuItem.Size = new System.Drawing.Size(237, 34);
            this.ramMenuItem.Text = "RAM(运行内存)";
            // 
            // gpuMenuItem
            // 
            this.gpuMenuItem.Name = "gpuMenuItem";
            this.gpuMenuItem.Size = new System.Drawing.Size(237, 34);
            this.gpuMenuItem.Text = "GPU(独立显卡)";
            // 
            // fanControllerMenuItem
            // 
            this.fanControllerMenuItem.Name = "fanControllerMenuItem";
            this.fanControllerMenuItem.Size = new System.Drawing.Size(237, 34);
            this.fanControllerMenuItem.Text = "风扇转速";
            // 
            // hddMenuItem
            // 
            this.hddMenuItem.Name = "hddMenuItem";
            this.hddMenuItem.Size = new System.Drawing.Size(237, 34);
            this.hddMenuItem.Text = "硬盘";
            // 
            // nicMenuItem
            // 
            this.nicMenuItem.Name = "nicMenuItem";
            this.nicMenuItem.Size = new System.Drawing.Size(237, 34);
            this.nicMenuItem.Text = "网络";
            // 
            // psuMenuItem
            // 
            this.psuMenuItem.Name = "psuMenuItem";
            this.psuMenuItem.Size = new System.Drawing.Size(237, 34);
            this.psuMenuItem.Text = "电源";
            // 
            // batteryMenuItem
            // 
            this.batteryMenuItem.Name = "batteryMenuItem";
            this.batteryMenuItem.Size = new System.Drawing.Size(237, 34);
            this.batteryMenuItem.Text = "电池";
            // 
            // menuItem6
            // 
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Size = new System.Drawing.Size(179, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(182, 34);
            this.exitMenuItem.Text = "关闭程序";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMinMaxMenuItem,
            this.resetPlotMenuItem,
            this.MenuItem3,
            this.hiddenMenuItem,
            this.plotMenuItem,
            this.gadgetMenuItem,
            this.MenuItem1,
            this.columnsMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(62, 28);
            this.viewMenuItem.Text = "视图";
            // 
            // resetMinMaxMenuItem
            // 
            this.resetMinMaxMenuItem.Name = "resetMinMaxMenuItem";
            this.resetMinMaxMenuItem.Size = new System.Drawing.Size(262, 34);
            this.resetMinMaxMenuItem.Text = "还原 最大/小值";
            this.resetMinMaxMenuItem.Click += new System.EventHandler(this.ResetMinMaxMenuItem_Click);
            // 
            // resetPlotMenuItem
            // 
            this.resetPlotMenuItem.Name = "resetPlotMenuItem";
            this.resetPlotMenuItem.Size = new System.Drawing.Size(262, 34);
            this.resetPlotMenuItem.Text = "重置视图";
            this.resetPlotMenuItem.Click += new System.EventHandler(this.resetPlotMenuItem_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(259, 6);
            // 
            // hiddenMenuItem
            // 
            this.hiddenMenuItem.Name = "hiddenMenuItem";
            this.hiddenMenuItem.Size = new System.Drawing.Size(262, 34);
            this.hiddenMenuItem.Text = "显示/隐藏的传感器";
            // 
            // plotMenuItem
            // 
            this.plotMenuItem.Name = "plotMenuItem";
            this.plotMenuItem.Size = new System.Drawing.Size(262, 34);
            this.plotMenuItem.Text = "显示绘图";
            // 
            // gadgetMenuItem
            // 
            this.gadgetMenuItem.Name = "gadgetMenuItem";
            this.gadgetMenuItem.Size = new System.Drawing.Size(262, 34);
            this.gadgetMenuItem.Text = "显示小部件";
            // 
            // MenuItem1
            // 
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(259, 6);
            // 
            // columnsMenuItem
            // 
            this.columnsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueMenuItem,
            this.minMenuItem,
            this.maxMenuItem});
            this.columnsMenuItem.Name = "columnsMenuItem";
            this.columnsMenuItem.Size = new System.Drawing.Size(262, 34);
            this.columnsMenuItem.Text = "参数";
            // 
            // valueMenuItem
            // 
            this.valueMenuItem.Name = "valueMenuItem";
            this.valueMenuItem.Size = new System.Drawing.Size(158, 34);
            this.valueMenuItem.Text = "Value";
            // 
            // minMenuItem
            // 
            this.minMenuItem.Name = "minMenuItem";
            this.minMenuItem.Size = new System.Drawing.Size(158, 34);
            this.minMenuItem.Text = "Min";
            // 
            // maxMenuItem
            // 
            this.maxMenuItem.Name = "maxMenuItem";
            this.maxMenuItem.Size = new System.Drawing.Size(158, 34);
            this.maxMenuItem.Text = "Max";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMinMenuItem,
            this.minTrayMenuItem,
            this.minCloseMenuItem,
            this.startupMenuItem,
            this.separatorMenuItem,
            this.temperatureUnitsMenuItem,
            this.plotLocationMenuItem,
            this.splitPlotPanelScalingMenuItem,
            this.logSeparatorMenuItem,
            this.logSensorsMenuItem,
            this.loggingIntervalMenuItem,
            this.updateIntervalMenuItem,
            this.sensorValuesTimeWindowMenuItem,
            this.webMenuItemSeparator,
            this.webMenuItem});
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(98, 28);
            this.optionsMenuItem.Text = "更多设置";
            // 
            // startMinMenuItem
            // 
            this.startMinMenuItem.Name = "startMinMenuItem";
            this.startMinMenuItem.Size = new System.Drawing.Size(297, 56);
            this.startMinMenuItem.Text = "最小化 启动";
            // 
            // minTrayMenuItem
            // 
            this.minTrayMenuItem.Name = "minTrayMenuItem";
            this.minTrayMenuItem.Size = new System.Drawing.Size(297, 56);
            this.minTrayMenuItem.Text = "最小化到托盘";
            // 
            // minCloseMenuItem
            // 
            this.minCloseMenuItem.Name = "minCloseMenuItem";
            this.minCloseMenuItem.Size = new System.Drawing.Size(297, 56);
            this.minCloseMenuItem.Text = "硬件关闭时最小化\n";
            // 
            // startupMenuItem
            // 
            this.startupMenuItem.Name = "startupMenuItem";
            this.startupMenuItem.Size = new System.Drawing.Size(297, 56);
            this.startupMenuItem.Text = "在Windows启动时运行";
            // 
            // separatorMenuItem
            // 
            this.separatorMenuItem.Name = "separatorMenuItem";
            this.separatorMenuItem.Size = new System.Drawing.Size(294, 6);
            // 
            // temperatureUnitsMenuItem
            // 
            this.temperatureUnitsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusMenuItem,
            this.fahrenheitMenuItem});
            this.temperatureUnitsMenuItem.Name = "temperatureUnitsMenuItem";
            this.temperatureUnitsMenuItem.Size = new System.Drawing.Size(297, 56);
            this.temperatureUnitsMenuItem.Text = "温度单位";
            // 
            // plotLocationMenuItem
            // 
            this.plotLocationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotWindowMenuItem,
            this.plotBottomMenuItem,
            this.plotRightMenuItem});
            this.plotLocationMenuItem.Name = "plotLocationMenuItem";
            this.plotLocationMenuItem.Size = new System.Drawing.Size(297, 56);
            this.plotLocationMenuItem.Text = "绘图位置";
            // 
            // splitPlotPanelScalingMenuItem
            // 
            this.splitPlotPanelScalingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitPanelPercentageScalingMenuItem,
            this.splitPanelFixedPlotScalingMenuItem,
            this.splitPanelFixedSensorScalingMenuItem});
            this.splitPlotPanelScalingMenuItem.Name = "splitPlotPanelScalingMenuItem";
            this.splitPlotPanelScalingMenuItem.Size = new System.Drawing.Size(297, 56);
            this.splitPlotPanelScalingMenuItem.Text = "拆分面板缩放模式";
            // 
            // logSeparatorMenuItem
            // 
            this.logSeparatorMenuItem.Name = "logSeparatorMenuItem";
            this.logSeparatorMenuItem.Size = new System.Drawing.Size(294, 6);
            // 
            // logSensorsMenuItem
            // 
            this.logSensorsMenuItem.Name = "logSensorsMenuItem";
            this.logSensorsMenuItem.Size = new System.Drawing.Size(297, 56);
            this.logSensorsMenuItem.Text = "传感器日志";
            this.logSensorsMenuItem.Click += new System.EventHandler(this.logSensorsMenuItem_Click);
            // 
            // loggingIntervalMenuItem
            // 
            this.loggingIntervalMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.log1sMenuItem,
            this.log2sMenuItem,
            this.log5sMenuItem,
            this.log10sMenuItem,
            this.log30sMenuItem,
            this.log1minMenuItem,
            this.log2minMenuItem,
            this.log5minMenuItem,
            this.log10minMenuItem,
            this.log30minMenuItem,
            this.log1hMenuItem,
            this.log2hMenuItem,
            this.log6hMenuItem});
            this.loggingIntervalMenuItem.Name = "loggingIntervalMenuItem";
            this.loggingIntervalMenuItem.Size = new System.Drawing.Size(297, 56);
            this.loggingIntervalMenuItem.Text = "日志记录间隔";
            // 
            // updateIntervalMenuItem
            // 
            this.updateIntervalMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInterval250msMenuItem,
            this.updateInterval500msMenuItem,
            this.updateInterval1sMenuItem,
            this.updateInterval2sMenuItem,
            this.updateInterval5sMenuItem,
            this.updateInterval10sMenuItem});
            this.updateIntervalMenuItem.Name = "updateIntervalMenuItem";
            this.updateIntervalMenuItem.Size = new System.Drawing.Size(297, 56);
            this.updateIntervalMenuItem.Text = "更新间隔";
            // 
            // sensorValuesTimeWindowMenuItem
            // 
            this.sensorValuesTimeWindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeWindow30sMenuItem,
            this.timeWindow1minMenuItem,
            this.timeWindow2minMenuItem,
            this.timeWindow5minMenuItem,
            this.timeWindow10minMenuItem,
            this.timeWindow30minMenuItem,
            this.timeWindow1hMenuItem,
            this.timeWindow2hMenuItem,
            this.timeWindow6hMenuItem,
            this.timeWindow12hMenuItem,
            this.timeWindow24hMenuItem});
            this.sensorValuesTimeWindowMenuItem.Name = "sensorValuesTimeWindowMenuItem";
            this.sensorValuesTimeWindowMenuItem.Size = new System.Drawing.Size(297, 56);
            this.sensorValuesTimeWindowMenuItem.Text = "传感器值时间窗口";
            this.sensorValuesTimeWindowMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webMenuItemSeparator
            // 
            this.webMenuItemSeparator.Name = "webMenuItemSeparator";
            this.webMenuItemSeparator.Size = new System.Drawing.Size(294, 6);
            // 
            // webMenuItem
            // 
            this.webMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runWebServerMenuItem,
            this.serverPortMenuItem,
            this.authWebServerMenuItem});
            this.webMenuItem.Name = "webMenuItem";
            this.webMenuItem.Size = new System.Drawing.Size(297, 56);
            this.webMenuItem.Text = "远程Web服务器";
            // 
            // runWebServerMenuItem
            // 
            this.runWebServerMenuItem.Name = "runWebServerMenuItem";
            this.runWebServerMenuItem.Size = new System.Drawing.Size(182, 34);
            this.runWebServerMenuItem.Text = "运行";
            // 
            // serverPortMenuItem
            // 
            this.serverPortMenuItem.Name = "serverPortMenuItem";
            this.serverPortMenuItem.Size = new System.Drawing.Size(182, 34);
            this.serverPortMenuItem.Text = "端口";
            this.serverPortMenuItem.Click += new System.EventHandler(this.ServerPortMenuItem_Click);
            // 
            // authWebServerMenuItem
            // 
            this.authWebServerMenuItem.Name = "authWebServerMenuItem";
            this.authWebServerMenuItem.Size = new System.Drawing.Size(182, 34);
            this.authWebServerMenuItem.Text = "身份验证";
            this.authWebServerMenuItem.Click += new System.EventHandler(this.AuthWebServerMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.toolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(67, 28);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(146, 34);
            this.aboutMenuItem.Text = "关于";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.其他待补充ToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.toolStripMenuItem.Text = "说明";
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.treeContextMenu.Name = "treeContextMenu";
            this.treeContextMenu.Size = new System.Drawing.Size(61, 4);
            this.treeContextMenu.Text = "test111";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "LibreHardwareMonitor.Report.txt";
            this.saveFileDialog.Filter = "Text Documents|*.txt|All Files|*.*";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save Report As";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(344, 30);
            this.toolStripMenuItem1.Text = "双击可以隐藏对应数值";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 其他待补充ToolStripMenuItem
            // 
            this.其他待补充ToolStripMenuItem.Name = "其他待补充ToolStripMenuItem";
            this.其他待补充ToolStripMenuItem.Size = new System.Drawing.Size(434, 34);
            this.其他待补充ToolStripMenuItem.Text = "其他待补充";
            // 
            // splitContainer
            // 
            this.splitContainer.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.splitContainer.Color = System.Drawing.SystemColors.Control;
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Location = new System.Drawing.Point(18, 18);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Size = new System.Drawing.Size(579, 669);
            this.splitContainer.SplitterDistance = 490;
            this.splitContainer.SplitterWidth = 7;
            this.splitContainer.TabIndex = 3;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Columns.Add(this.sensor);
            this.treeView.Columns.Add(this.value);
            this.treeView.Columns.Add(this.min);
            this.treeView.Columns.Add(this.max);
            this.treeView.DefaultToolTipProvider = null;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.GridLineStyle = Aga.Controls.Tree.GridLineStyle.Horizontal;
            this.treeView.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Model = null;
            this.treeView.Name = "treeView";
            this.treeView.NodeControls.Add(this.nodeImage);
            this.treeView.NodeControls.Add(this.nodeCheckBox);
            this.treeView.NodeControls.Add(this.nodeTextBoxText);
            this.treeView.NodeControls.Add(this.nodeTextBoxValue);
            this.treeView.NodeControls.Add(this.nodeTextBoxMin);
            this.treeView.NodeControls.Add(this.nodeTextBoxMax);
            this.treeView.SelectedNode = null;
            this.treeView.Size = new System.Drawing.Size(579, 490);
            this.treeView.TabIndex = 0;
            this.treeView.Text = "treeView";
            this.treeView.UseColumns = true;
            this.treeView.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.TreeView_NodeMouseDoubleClick);
            this.treeView.Click += new System.EventHandler(this.TreeView_Click);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseMove);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseUp);
            // 
            // celsiusMenuItem
            // 
            this.celsiusMenuItem.CheckOnClick = true;
            this.celsiusMenuItem.Name = "celsiusMenuItem";
            this.celsiusMenuItem.Size = new System.Drawing.Size(164, 34);
            this.celsiusMenuItem.Text = "摄氏度";
            this.celsiusMenuItem.Click += new System.EventHandler(this.CelsiusMenuItem_Click);
            // 
            // fahrenheitMenuItem
            // 
            this.fahrenheitMenuItem.CheckOnClick = true;
            this.fahrenheitMenuItem.Name = "fahrenheitMenuItem";
            this.fahrenheitMenuItem.Size = new System.Drawing.Size(164, 34);
            this.fahrenheitMenuItem.Text = "华氏度";
            this.fahrenheitMenuItem.Click += new System.EventHandler(this.FahrenheitMenuItem_Click);
            // 
            // plotWindowMenuItem
            // 
            this.plotWindowMenuItem.CheckOnClick = true;
            this.plotWindowMenuItem.Name = "plotWindowMenuItem";
            this.plotWindowMenuItem.Size = new System.Drawing.Size(181, 34);
            this.plotWindowMenuItem.Text = "Window";
            // 
            // plotBottomMenuItem
            // 
            this.plotBottomMenuItem.CheckOnClick = true;
            this.plotBottomMenuItem.Name = "plotBottomMenuItem";
            this.plotBottomMenuItem.Size = new System.Drawing.Size(181, 34);
            this.plotBottomMenuItem.Text = "底栏";
            // 
            // plotRightMenuItem
            // 
            this.plotRightMenuItem.CheckOnClick = true;
            this.plotRightMenuItem.Name = "plotRightMenuItem";
            this.plotRightMenuItem.Size = new System.Drawing.Size(181, 34);
            this.plotRightMenuItem.Text = "右边";
            // 
            // splitPanelPercentageScalingMenuItem
            // 
            this.splitPanelPercentageScalingMenuItem.CheckOnClick = true;
            this.splitPanelPercentageScalingMenuItem.Name = "splitPanelPercentageScalingMenuItem";
            this.splitPanelPercentageScalingMenuItem.Size = new System.Drawing.Size(286, 34);
            this.splitPanelPercentageScalingMenuItem.Text = "百分比缩放";
            // 
            // splitPanelFixedPlotScalingMenuItem
            // 
            this.splitPanelFixedPlotScalingMenuItem.CheckOnClick = true;
            this.splitPanelFixedPlotScalingMenuItem.Name = "splitPanelFixedPlotScalingMenuItem";
            this.splitPanelFixedPlotScalingMenuItem.Size = new System.Drawing.Size(286, 34);
            this.splitPanelFixedPlotScalingMenuItem.Text = "Fixed Size Plot Panel";
            // 
            // splitPanelFixedSensorScalingMenuItem
            // 
            this.splitPanelFixedSensorScalingMenuItem.CheckOnClick = true;
            this.splitPanelFixedSensorScalingMenuItem.Name = "splitPanelFixedSensorScalingMenuItem";
            this.splitPanelFixedSensorScalingMenuItem.Size = new System.Drawing.Size(286, 34);
            this.splitPanelFixedSensorScalingMenuItem.Text = "固定尺寸传感器面板";
            // 
            // log1sMenuItem
            // 
            this.log1sMenuItem.CheckOnClick = true;
            this.log1sMenuItem.Name = "log1sMenuItem";
            this.log1sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log1sMenuItem.Text = "1s";
            // 
            // log2sMenuItem
            // 
            this.log2sMenuItem.CheckOnClick = true;
            this.log2sMenuItem.Name = "log2sMenuItem";
            this.log2sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log2sMenuItem.Text = "2s";
            // 
            // log5sMenuItem
            // 
            this.log5sMenuItem.CheckOnClick = true;
            this.log5sMenuItem.Name = "log5sMenuItem";
            this.log5sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log5sMenuItem.Text = "5s";
            // 
            // log10sMenuItem
            // 
            this.log10sMenuItem.CheckOnClick = true;
            this.log10sMenuItem.Name = "log10sMenuItem";
            this.log10sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log10sMenuItem.Text = "10s";
            // 
            // log30sMenuItem
            // 
            this.log30sMenuItem.CheckOnClick = true;
            this.log30sMenuItem.Name = "log30sMenuItem";
            this.log30sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log30sMenuItem.Text = "30s";
            // 
            // log1minMenuItem
            // 
            this.log1minMenuItem.CheckOnClick = true;
            this.log1minMenuItem.Name = "log1minMenuItem";
            this.log1minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log1minMenuItem.Text = "1min";
            // 
            // log2minMenuItem
            // 
            this.log2minMenuItem.CheckOnClick = true;
            this.log2minMenuItem.Name = "log2minMenuItem";
            this.log2minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log2minMenuItem.Text = "2min";
            // 
            // log5minMenuItem
            // 
            this.log5minMenuItem.CheckOnClick = true;
            this.log5minMenuItem.Name = "log5minMenuItem";
            this.log5minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log5minMenuItem.Text = "5min";
            // 
            // log10minMenuItem
            // 
            this.log10minMenuItem.CheckOnClick = true;
            this.log10minMenuItem.Name = "log10minMenuItem";
            this.log10minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log10minMenuItem.Text = "10min";
            // 
            // log30minMenuItem
            // 
            this.log30minMenuItem.CheckOnClick = true;
            this.log30minMenuItem.Name = "log30minMenuItem";
            this.log30minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log30minMenuItem.Text = "30min";
            // 
            // log1hMenuItem
            // 
            this.log1hMenuItem.CheckOnClick = true;
            this.log1hMenuItem.Name = "log1hMenuItem";
            this.log1hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log1hMenuItem.Text = "1h";
            // 
            // log2hMenuItem
            // 
            this.log2hMenuItem.CheckOnClick = true;
            this.log2hMenuItem.Name = "log2hMenuItem";
            this.log2hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log2hMenuItem.Text = "2h";
            // 
            // log6hMenuItem
            // 
            this.log6hMenuItem.CheckOnClick = true;
            this.log6hMenuItem.Name = "log6hMenuItem";
            this.log6hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.log6hMenuItem.Text = "6h";
            // 
            // updateInterval250msMenuItem
            // 
            this.updateInterval250msMenuItem.CheckOnClick = true;
            this.updateInterval250msMenuItem.Name = "updateInterval250msMenuItem";
            this.updateInterval250msMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval250msMenuItem.Text = "250ms";
            // 
            // updateInterval500msMenuItem
            // 
            this.updateInterval500msMenuItem.CheckOnClick = true;
            this.updateInterval500msMenuItem.Name = "updateInterval500msMenuItem";
            this.updateInterval500msMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval500msMenuItem.Text = "500ms";
            // 
            // updateInterval1sMenuItem
            // 
            this.updateInterval1sMenuItem.CheckOnClick = true;
            this.updateInterval1sMenuItem.Name = "updateInterval1sMenuItem";
            this.updateInterval1sMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval1sMenuItem.Text = "1s";
            // 
            // updateInterval2sMenuItem
            // 
            this.updateInterval2sMenuItem.CheckOnClick = true;
            this.updateInterval2sMenuItem.Name = "updateInterval2sMenuItem";
            this.updateInterval2sMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval2sMenuItem.Text = "2s";
            // 
            // updateInterval5sMenuItem
            // 
            this.updateInterval5sMenuItem.CheckOnClick = true;
            this.updateInterval5sMenuItem.Name = "updateInterval5sMenuItem";
            this.updateInterval5sMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval5sMenuItem.Text = "5s";
            // 
            // updateInterval10sMenuItem
            // 
            this.updateInterval10sMenuItem.CheckOnClick = true;
            this.updateInterval10sMenuItem.Name = "updateInterval10sMenuItem";
            this.updateInterval10sMenuItem.Size = new System.Drawing.Size(168, 34);
            this.updateInterval10sMenuItem.Text = "10s";
            // 
            // timeWindow30sMenuItem
            // 
            this.timeWindow30sMenuItem.CheckOnClick = true;
            this.timeWindow30sMenuItem.Name = "timeWindow30sMenuItem";
            this.timeWindow30sMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow30sMenuItem.Text = "30s";
            // 
            // timeWindow1minMenuItem
            // 
            this.timeWindow1minMenuItem.CheckOnClick = true;
            this.timeWindow1minMenuItem.Name = "timeWindow1minMenuItem";
            this.timeWindow1minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow1minMenuItem.Text = "1min";
            // 
            // timeWindow2minMenuItem
            // 
            this.timeWindow2minMenuItem.CheckOnClick = true;
            this.timeWindow2minMenuItem.Name = "timeWindow2minMenuItem";
            this.timeWindow2minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow2minMenuItem.Text = "2min";
            // 
            // timeWindow5minMenuItem
            // 
            this.timeWindow5minMenuItem.CheckOnClick = true;
            this.timeWindow5minMenuItem.Name = "timeWindow5minMenuItem";
            this.timeWindow5minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow5minMenuItem.Text = "5min";
            // 
            // timeWindow10minMenuItem
            // 
            this.timeWindow10minMenuItem.CheckOnClick = true;
            this.timeWindow10minMenuItem.Name = "timeWindow10minMenuItem";
            this.timeWindow10minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow10minMenuItem.Text = "10min";
            // 
            // timeWindow30minMenuItem
            // 
            this.timeWindow30minMenuItem.CheckOnClick = true;
            this.timeWindow30minMenuItem.Name = "timeWindow30minMenuItem";
            this.timeWindow30minMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow30minMenuItem.Text = "30min";
            // 
            // timeWindow1hMenuItem
            // 
            this.timeWindow1hMenuItem.CheckOnClick = true;
            this.timeWindow1hMenuItem.Name = "timeWindow1hMenuItem";
            this.timeWindow1hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow1hMenuItem.Text = "1h";
            // 
            // timeWindow2hMenuItem
            // 
            this.timeWindow2hMenuItem.CheckOnClick = true;
            this.timeWindow2hMenuItem.Name = "timeWindow2hMenuItem";
            this.timeWindow2hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow2hMenuItem.Text = "2h";
            // 
            // timeWindow6hMenuItem
            // 
            this.timeWindow6hMenuItem.CheckOnClick = true;
            this.timeWindow6hMenuItem.Name = "timeWindow6hMenuItem";
            this.timeWindow6hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow6hMenuItem.Text = "6h";
            // 
            // timeWindow12hMenuItem
            // 
            this.timeWindow12hMenuItem.CheckOnClick = true;
            this.timeWindow12hMenuItem.Name = "timeWindow12hMenuItem";
            this.timeWindow12hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow12hMenuItem.Text = "12h";
            // 
            // timeWindow24hMenuItem
            // 
            this.timeWindow24hMenuItem.CheckOnClick = true;
            this.timeWindow24hMenuItem.Name = "timeWindow24hMenuItem";
            this.timeWindow24hMenuItem.Size = new System.Drawing.Size(165, 34);
            this.timeWindow24hMenuItem.Text = "24h";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 738);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "设备信息查看";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_MoveOrResize);
            this.Move += new System.EventHandler(this.MainForm_MoveOrResize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeView;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private Aga.Controls.Tree.TreeColumn sensor;
        private Aga.Controls.Tree.TreeColumn value;
        private Aga.Controls.Tree.TreeColumn min;
        private Aga.Controls.Tree.TreeColumn max;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeImage;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxText;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxValue;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMin;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMax;
        private SplitContainerAdv splitContainer;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotMenuItem;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox nodeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorMenuItem;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem startMinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem hiddenMenuItem;
        private System.Windows.Forms.ToolStripSeparator MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem columnsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureUnitsMenuItem;
        private System.Windows.Forms.ToolStripSeparator webMenuItemSeparator;
        private ToolStripRadioButtonMenuItem celsiusMenuItem;
        private ToolStripRadioButtonMenuItem fahrenheitMenuItem;
        private System.Windows.Forms.ToolStripSeparator MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetMinMaxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPlotMenuItem;
        private System.Windows.Forms.ToolStripSeparator MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gadgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minCloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuItem6;
        private System.Windows.Forms.ToolStripMenuItem plotLocationMenuItem;
        private ToolStripRadioButtonMenuItem plotWindowMenuItem;
        private ToolStripRadioButtonMenuItem plotBottomMenuItem;
        private ToolStripRadioButtonMenuItem plotRightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitPlotPanelScalingMenuItem;
        private ToolStripRadioButtonMenuItem splitPanelPercentageScalingMenuItem;
        private ToolStripRadioButtonMenuItem splitPanelFixedPlotScalingMenuItem;
        private ToolStripRadioButtonMenuItem splitPanelFixedSensorScalingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runWebServerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverPortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem5;
        private System.Windows.Forms.ToolStripMenuItem mainboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanControllerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logSensorsMenuItem;
        private System.Windows.Forms.ToolStripSeparator logSeparatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingIntervalMenuItem;
        private ToolStripRadioButtonMenuItem log1sMenuItem;
        private ToolStripRadioButtonMenuItem log2sMenuItem;
        private ToolStripRadioButtonMenuItem log5sMenuItem;
        private ToolStripRadioButtonMenuItem log10sMenuItem;
        private ToolStripRadioButtonMenuItem log30sMenuItem;
        private ToolStripRadioButtonMenuItem log1minMenuItem;
        private ToolStripRadioButtonMenuItem log2minMenuItem;
        private ToolStripRadioButtonMenuItem log5minMenuItem;
        private ToolStripRadioButtonMenuItem log10minMenuItem;
        private ToolStripRadioButtonMenuItem log30minMenuItem;
        private ToolStripRadioButtonMenuItem log1hMenuItem;
        private ToolStripRadioButtonMenuItem log2hMenuItem;
        private ToolStripRadioButtonMenuItem log6hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIntervalMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval250msMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval500msMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval1sMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval2sMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval5sMenuItem;
        private ToolStripRadioButtonMenuItem updateInterval10sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorValuesTimeWindowMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow30sMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow1minMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow2minMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow5minMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow10minMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow30minMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow1hMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow2hMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow6hMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow12hMenuItem;
        private ToolStripRadioButtonMenuItem timeWindow24hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authWebServerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundUpdater;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 其他待补充ToolStripMenuItem;
    }
}

