namespace MovieManager
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.movieGrid = new DevExpress.XtraGrid.GridControl();
            this.movieGridViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMovieId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenreType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeasons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWatched = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWatchList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gridWatchList = new DevExpress.XtraGrid.GridControl();
            this.watchListGridViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewWatchList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWatchListId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRating2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducer1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeasons1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridWatched = new DevExpress.XtraGrid.GridControl();
            this.watchedGridViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewWatched = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWatchedId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRating1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridWatcheditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridWatchListitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.Movies = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlMovies = new DevExpress.XtraEditors.PanelControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlWatched = new DevExpress.XtraEditors.PanelControl();
            this.buttonRefreshWatched = new System.Windows.Forms.Button();
            this.buttonDeleteWatched = new System.Windows.Forms.Button();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGridViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListGridViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedGridViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatcheditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatchListitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMovies)).BeginInit();
            this.panelControlMovies.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlWatched)).BeginInit();
            this.panelControlWatched.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(271, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(90, 34);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // movieGrid
            // 
            this.movieGrid.DataSource = this.movieGridViewModelBindingSource;
            this.movieGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieGrid.Location = new System.Drawing.Point(0, 0);
            this.movieGrid.MainView = this.gridView1;
            this.movieGrid.Name = "movieGrid";
            this.movieGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.movieGrid.Size = new System.Drawing.Size(1362, 654);
            this.movieGrid.TabIndex = 3;
            this.movieGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.movieGrid.Click += new System.EventHandler(this.movieGrid_Click_1);
            // 
            // movieGridViewModelBindingSource
            // 
            this.movieGridViewModelBindingSource.DataSource = typeof(MovieManager.MovieGridViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMovieId,
            this.colTitle,
            this.colRating,
            this.colGenreType,
            this.colTest,
            this.colYear,
            this.colDescription,
            this.colSeasons,
            this.colStatus,
            this.colWatched,
            this.colWatchList});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.movieGrid;
            this.gridView1.Name = "gridView1";
            // 
            // colMovieId
            // 
            this.colMovieId.FieldName = "MovieId";
            this.colMovieId.Name = "colMovieId";
            this.colMovieId.OptionsColumn.ReadOnly = true;
            this.colMovieId.Visible = true;
            this.colMovieId.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colRating
            // 
            this.colRating.FieldName = "Rating";
            this.colRating.Name = "colRating";
            this.colRating.Visible = true;
            this.colRating.VisibleIndex = 2;
            // 
            // colGenreType
            // 
            this.colGenreType.ColumnEdit = this.repositoryItemComboBox1;
            this.colGenreType.FieldName = "GenreType";
            this.colGenreType.Name = "colGenreType";
            this.colGenreType.Visible = true;
            this.colGenreType.VisibleIndex = 3;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colTest
            // 
            this.colTest.FieldName = "Test";
            this.colTest.Name = "colTest";
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colSeasons
            // 
            this.colSeasons.FieldName = "Seasons";
            this.colSeasons.Name = "colSeasons";
            this.colSeasons.Visible = true;
            this.colSeasons.VisibleIndex = 6;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            // 
            // colWatched
            // 
            this.colWatched.FieldName = "Watched";
            this.colWatched.Name = "colWatched";
            this.colWatched.Visible = true;
            this.colWatched.VisibleIndex = 8;
            // 
            // colWatchList
            // 
            this.colWatchList.FieldName = "WatchList";
            this.colWatchList.Name = "colWatchList";
            this.colWatchList.Visible = true;
            this.colWatchList.VisibleIndex = 9;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(559, 34);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // gridWatchList
            // 
            this.gridWatchList.DataSource = this.watchListGridViewModelBindingSource;
            this.gridWatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWatchList.Location = new System.Drawing.Point(0, 0);
            this.gridWatchList.MainView = this.gridViewWatchList;
            this.gridWatchList.Name = "gridWatchList";
            this.gridWatchList.Size = new System.Drawing.Size(1362, 654);
            this.gridWatchList.TabIndex = 7;
            this.gridWatchList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWatchList});
            this.gridWatchList.Click += new System.EventHandler(this.gridWatchList_Click);
            // 
            // watchListGridViewModelBindingSource
            // 
            this.watchListGridViewModelBindingSource.DataSource = typeof(MovieManager.WatchListGridViewModel);
            // 
            // gridViewWatchList
            // 
            this.gridViewWatchList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWatchListId,
            this.colMovieId2,
            this.colTitle2,
            this.colRating2,
            this.colProducer1,
            this.colGenre1,
            this.colYear2,
            this.colDescription2,
            this.colSeasons1,
            this.colStatus2});
            this.gridViewWatchList.GridControl = this.gridWatchList;
            this.gridViewWatchList.Name = "gridViewWatchList";
            // 
            // colWatchListId
            // 
            this.colWatchListId.FieldName = "WatchListId";
            this.colWatchListId.Name = "colWatchListId";
            this.colWatchListId.Visible = true;
            this.colWatchListId.VisibleIndex = 0;
            this.colWatchListId.Width = 170;
            // 
            // colMovieId2
            // 
            this.colMovieId2.FieldName = "MovieId";
            this.colMovieId2.Name = "colMovieId2";
            this.colMovieId2.Visible = true;
            this.colMovieId2.VisibleIndex = 1;
            this.colMovieId2.Width = 170;
            // 
            // colTitle2
            // 
            this.colTitle2.FieldName = "Title";
            this.colTitle2.Name = "colTitle2";
            this.colTitle2.Visible = true;
            this.colTitle2.VisibleIndex = 2;
            this.colTitle2.Width = 170;
            // 
            // colRating2
            // 
            this.colRating2.FieldName = "Rating";
            this.colRating2.Name = "colRating2";
            this.colRating2.Visible = true;
            this.colRating2.VisibleIndex = 3;
            this.colRating2.Width = 170;
            // 
            // colProducer1
            // 
            this.colProducer1.FieldName = "Producer";
            this.colProducer1.Name = "colProducer1";
            this.colProducer1.Visible = true;
            this.colProducer1.VisibleIndex = 4;
            this.colProducer1.Width = 170;
            // 
            // colGenre1
            // 
            this.colGenre1.FieldName = "Genre";
            this.colGenre1.Name = "colGenre1";
            this.colGenre1.Visible = true;
            this.colGenre1.VisibleIndex = 5;
            this.colGenre1.Width = 170;
            // 
            // colYear2
            // 
            this.colYear2.FieldName = "Year";
            this.colYear2.Name = "colYear2";
            this.colYear2.Visible = true;
            this.colYear2.VisibleIndex = 6;
            this.colYear2.Width = 102;
            // 
            // colDescription2
            // 
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Visible = true;
            this.colDescription2.VisibleIndex = 7;
            this.colDescription2.Width = 192;
            // 
            // colSeasons1
            // 
            this.colSeasons1.FieldName = "Seasons";
            this.colSeasons1.Name = "colSeasons1";
            this.colSeasons1.Visible = true;
            this.colSeasons1.VisibleIndex = 8;
            this.colSeasons1.Width = 73;
            // 
            // colStatus2
            // 
            this.colStatus2.FieldName = "Status";
            this.colStatus2.Name = "colStatus2";
            this.colStatus2.Visible = true;
            this.colStatus2.VisibleIndex = 9;
            this.colStatus2.Width = 322;
            // 
            // gridWatched
            // 
            this.gridWatched.DataSource = this.watchedGridViewModelBindingSource1;
            this.gridWatched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWatched.Location = new System.Drawing.Point(0, 0);
            this.gridWatched.MainView = this.gridViewWatched;
            this.gridWatched.Name = "gridWatched";
            this.gridWatched.Size = new System.Drawing.Size(1362, 654);
            this.gridWatched.TabIndex = 8;
            this.gridWatched.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWatched});
            this.gridWatched.Click += new System.EventHandler(this.gridWatched_Click);
            // 
            // watchedGridViewModelBindingSource1
            // 
            this.watchedGridViewModelBindingSource1.DataSource = typeof(MovieManager.WatchedGridViewModel);
            // 
            // gridViewWatched
            // 
            this.gridViewWatched.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWatchedId,
            this.colMovieId1,
            this.colTitle1,
            this.colRating1,
            this.colProducer,
            this.colGenre,
            this.colYear1,
            this.colDescription1,
            this.colStatus1});
            this.gridViewWatched.GridControl = this.gridWatched;
            this.gridViewWatched.Name = "gridViewWatched";
            // 
            // colWatchedId
            // 
            this.colWatchedId.FieldName = "WatchedId";
            this.colWatchedId.Name = "colWatchedId";
            this.colWatchedId.Visible = true;
            this.colWatchedId.VisibleIndex = 0;
            this.colWatchedId.Width = 87;
            // 
            // colMovieId1
            // 
            this.colMovieId1.FieldName = "MovieId";
            this.colMovieId1.Name = "colMovieId1";
            this.colMovieId1.OptionsColumn.ReadOnly = true;
            this.colMovieId1.Visible = true;
            this.colMovieId1.VisibleIndex = 1;
            this.colMovieId1.Width = 67;
            // 
            // colTitle1
            // 
            this.colTitle1.FieldName = "Title";
            this.colTitle1.Name = "colTitle1";
            this.colTitle1.OptionsColumn.ReadOnly = true;
            this.colTitle1.Visible = true;
            this.colTitle1.VisibleIndex = 2;
            this.colTitle1.Width = 73;
            // 
            // colRating1
            // 
            this.colRating1.FieldName = "Rating";
            this.colRating1.Name = "colRating1";
            this.colRating1.OptionsColumn.ReadOnly = true;
            this.colRating1.Visible = true;
            this.colRating1.VisibleIndex = 3;
            this.colRating1.Width = 180;
            // 
            // colProducer
            // 
            this.colProducer.FieldName = "Producer";
            this.colProducer.Name = "colProducer";
            this.colProducer.OptionsColumn.ReadOnly = true;
            this.colProducer.Visible = true;
            this.colProducer.VisibleIndex = 4;
            this.colProducer.Width = 180;
            // 
            // colGenre
            // 
            this.colGenre.FieldName = "Genre";
            this.colGenre.Name = "colGenre";
            this.colGenre.OptionsColumn.ReadOnly = true;
            this.colGenre.Visible = true;
            this.colGenre.VisibleIndex = 5;
            this.colGenre.Width = 114;
            // 
            // colYear1
            // 
            this.colYear1.FieldName = "Year";
            this.colYear1.Name = "colYear1";
            this.colYear1.OptionsColumn.ReadOnly = true;
            this.colYear1.Visible = true;
            this.colYear1.VisibleIndex = 6;
            this.colYear1.Width = 106;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.OptionsColumn.ReadOnly = true;
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 7;
            this.colDescription1.Width = 184;
            // 
            // colStatus1
            // 
            this.colStatus1.FieldName = "Status";
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.OptionsColumn.ReadOnly = true;
            this.colStatus1.Visible = true;
            this.colStatus1.VisibleIndex = 8;
            this.colStatus1.Width = 353;
            // 
            // gridWatcheditem
            // 
            this.gridWatcheditem.Control = this.gridWatched;
            this.gridWatcheditem.Location = new System.Drawing.Point(0, 207);
            this.gridWatcheditem.Name = "gridWatcheditem";
            this.gridWatcheditem.Size = new System.Drawing.Size(1275, 163);
            this.gridWatcheditem.TextSize = new System.Drawing.Size(0, 0);
            this.gridWatcheditem.TextVisible = false;
            // 
            // gridWatchListitem
            // 
            this.gridWatchListitem.Control = this.gridWatchList;
            this.gridWatchListitem.Location = new System.Drawing.Point(0, 183);
            this.gridWatchListitem.Name = "gridWatchListitem";
            this.gridWatchListitem.Size = new System.Drawing.Size(1275, 24);
            this.gridWatchListitem.TextSize = new System.Drawing.Size(0, 0);
            this.gridWatchListitem.TextVisible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(411, 34);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.Movies);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Movies,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1380, 718);
            this.tabPane1.SelectedPage = this.Movies;
            this.tabPane1.Size = new System.Drawing.Size(1380, 718);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // Movies
            // 
            this.Movies.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Movies.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Movies.Appearance.Options.UseBackColor = true;
            this.Movies.Appearance.Options.UseForeColor = true;
            this.Movies.Caption = "All Movies";
            this.Movies.Controls.Add(this.panelControlMovies);
            this.Movies.Controls.Add(this.movieGrid);
            this.Movies.Image = ((System.Drawing.Image)(resources.GetObject("Movies.Image")));
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(1362, 654);
            this.Movies.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage1_Paint);
            // 
            // panelControlMovies
            // 
            this.panelControlMovies.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControlMovies.Appearance.BackColor2 = System.Drawing.Color.Aqua;
            this.panelControlMovies.Appearance.BorderColor = System.Drawing.Color.Red;
            this.panelControlMovies.Appearance.ForeColor = System.Drawing.Color.Black;
            this.panelControlMovies.Appearance.Options.UseBackColor = true;
            this.panelControlMovies.Appearance.Options.UseBorderColor = true;
            this.panelControlMovies.Appearance.Options.UseForeColor = true;
            this.panelControlMovies.Controls.Add(this.buttonRefresh);
            this.panelControlMovies.Controls.Add(this.buttonSave);
            this.panelControlMovies.Controls.Add(this.buttonRemove);
            this.panelControlMovies.Controls.Add(this.buttonAdd);
            this.panelControlMovies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMovies.Location = new System.Drawing.Point(0, 554);
            this.panelControlMovies.Name = "panelControlMovies";
            this.panelControlMovies.Size = new System.Drawing.Size(1362, 100);
            this.panelControlMovies.TabIndex = 4;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Watched";
            this.tabNavigationPage2.Controls.Add(this.panelControlWatched);
            this.tabNavigationPage2.Controls.Add(this.gridWatched);
            this.tabNavigationPage2.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1362, 654);
            // 
            // panelControlWatched
            // 
            this.panelControlWatched.Appearance.ForeColor = System.Drawing.Color.Black;
            this.panelControlWatched.Appearance.Options.UseForeColor = true;
            this.panelControlWatched.Controls.Add(this.buttonRefreshWatched);
            this.panelControlWatched.Controls.Add(this.buttonDeleteWatched);
            this.panelControlWatched.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlWatched.Location = new System.Drawing.Point(0, 554);
            this.panelControlWatched.Name = "panelControlWatched";
            this.panelControlWatched.Size = new System.Drawing.Size(1362, 100);
            this.panelControlWatched.TabIndex = 9;
            // 
            // buttonRefreshWatched
            // 
            this.buttonRefreshWatched.Location = new System.Drawing.Point(595, 47);
            this.buttonRefreshWatched.Name = "buttonRefreshWatched";
            this.buttonRefreshWatched.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshWatched.TabIndex = 3;
            this.buttonRefreshWatched.Text = "Refresh";
            this.buttonRefreshWatched.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWatched
            // 
            this.buttonDeleteWatched.Location = new System.Drawing.Point(403, 47);
            this.buttonDeleteWatched.Name = "buttonDeleteWatched";
            this.buttonDeleteWatched.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWatched.TabIndex = 2;
            this.buttonDeleteWatched.Text = "Remove";
            this.buttonDeleteWatched.UseVisualStyleBackColor = true;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "WatchList";
            this.tabNavigationPage3.Controls.Add(this.gridWatchList);
            this.tabNavigationPage3.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.Image")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1362, 654);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1380, 718);
            this.Controls.Add(this.tabPane1);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGridViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListGridViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedGridViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatcheditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWatchListitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMovies)).EndInit();
            this.panelControlMovies.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlWatched)).EndInit();
            this.panelControlWatched.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private DevExpress.XtraGrid.GridControl movieGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource movieGridViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colRating;
        private DevExpress.XtraGrid.Columns.GridColumn colGenreType;
        private DevExpress.XtraGrid.Columns.GridColumn colTest;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSeasons;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colWatched;
        private DevExpress.XtraGrid.Columns.GridColumn colWatchList;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private DevExpress.XtraGrid.GridControl gridWatchList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWatchList;
        private DevExpress.XtraGrid.GridControl gridWatched;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWatched;
        private System.Windows.Forms.BindingSource watchedGridViewModelBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colWatchedId;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieId1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colRating1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducer;
        private DevExpress.XtraGrid.Columns.GridColumn colGenre;
        private DevExpress.XtraGrid.Columns.GridColumn colYear1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private System.Windows.Forms.BindingSource watchListGridViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWatchListId;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieId2;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle2;
        private DevExpress.XtraGrid.Columns.GridColumn colRating2;
        private DevExpress.XtraGrid.Columns.GridColumn colProducer1;
        private DevExpress.XtraGrid.Columns.GridColumn colGenre1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription2;
        private DevExpress.XtraGrid.Columns.GridColumn colSeasons1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem movieGriditem;
        private DevExpress.XtraLayout.LayoutControlItem gridWatcheditem;
        private DevExpress.XtraLayout.LayoutControlItem gridWatchListitem;
        private System.Windows.Forms.Button buttonRemove;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Movies;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.PanelControl panelControlMovies;
        private DevExpress.XtraEditors.PanelControl panelControlWatched;
        private System.Windows.Forms.Button buttonDeleteWatched;
        private System.Windows.Forms.Button buttonRefreshWatched;
    }
}