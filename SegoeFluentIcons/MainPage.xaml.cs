namespace SegoeFluentIcons;

public partial class MainPage : ContentPage
{
    int counter = 0;

    public MainPage()
	{
		InitializeComponent();
        AddAll();
    }

    void Add(string name, string value)
    {
        if (counter % 2 == 0) 
        {
            Root.RowDefinitions.Add(new RowDefinition());
        }

        var nameLabel = new Label
        {
            Text = name,
            FontSize = 16,
            Margin = new Thickness(5)
        };

        var iconLabel = new Label
        {
            FontFamily = "Segoe Fluent Icons",
            Text = value,
            FontSize = 16,
            Margin = new Thickness(5)
        };

        Root.SetRow(nameLabel, Root.RowDefinitions.Count - 1);
        Root.SetRow(iconLabel, Root.RowDefinitions.Count - 1);

        Root.SetColumn(nameLabel, counter % 2 == 0 ? 0 : 2);
        Root.SetColumn(iconLabel, counter % 2 == 0 ? 1 : 3);

        Root.Add(nameLabel);
        Root.Add(iconLabel);

        counter += 1;
    }

    void AddAll()
    {
        Add("Previous", Icon.Previous);
        Add("Next", Icon.Next);
        Add("Play", Icon.Play);
        Add("Pause", Icon.Pause);
        Add("Edit", Icon.Edit);
        Add("Save", Icon.Save);
        Add("Clear", Icon.Clear);
        Add("Delete", Icon.Delete);
        Add("Remove", Icon.Remove);
        Add("Add", Icon.Add);
        Add("Cancel", Icon.Cancel);
        Add("Accept", Icon.Accept);
        Add("More", Icon.More);
        Add("Redo", Icon.Redo);
        Add("Undo", Icon.Undo);
        Add("Home", Icon.Home);
        Add("Up", Icon.Up);
        Add("Forward", Icon.Forward);
        Add("Back", Icon.Back);
        Add("Favorite", Icon.Favorite);
        Add("Camera", Icon.Camera);
        Add("Setting", Icon.Setting);
        Add("Video", Icon.Video);
        Add("Sync", Icon.Sync);
        Add("Download", Icon.Download);
        Add("Mail", Icon.Mail);
        Add("Find", Icon.Find);
        Add("Help", Icon.Help);
        Add("Upload", Icon.Upload);
        Add("Emoji", Icon.Emoji);
        Add("TwoPage", Icon.TwoPage);
        Add("LeaveChat", Icon.LeaveChat);
        Add("MailForward", Icon.MailForward);
        Add("Clock", Icon.Clock);
        Add("Send", Icon.Send);
        Add("Crop", Icon.Crop);
        Add("RotateCamera", Icon.RotateCamera);
        Add("People", Icon.People);
        Add("OpenPane", Icon.OpenPane);
        Add("ClosePane", Icon.ClosePane);
        Add("World", Icon.World);
        Add("Flag", Icon.Flag);
        Add("PreviewLink", Icon.PreviewLink);
        Add("Globe", Icon.Globe);
        Add("Trim", Icon.Trim);
        Add("AttachCamera", Icon.AttachCamera);
        Add("ZoomIn", Icon.ZoomIn);
        Add("Bookmarks", Icon.Bookmarks);
        Add("Document", Icon.Document);
        Add("ProtectedDocument", Icon.ProtectedDocument);
        Add("Page", Icon.Page);
        Add("Bullets", Icon.Bullets);
        Add("Comment", Icon.Comment);
        Add("MailFilled", Icon.MailFilled);
        Add("ContactInfo", Icon.ContactInfo);
        Add("HangUp", Icon.HangUp);
        Add("ViewAll", Icon.ViewAll);
        Add("MapPin", Icon.MapPin);
        Add("Phone", Icon.Phone);
        Add("VideoChat", Icon.VideoChat);
        Add("Switch", Icon.Switch);
        Add("Contact", Icon.Contact);
        Add("Rename", Icon.Rename);
        Add("Pin", Icon.Pin);
        Add("MusicInfo", Icon.MusicInfo);
        Add("Go", Icon.Go);
        Add("Keyboard", Icon.Keyboard);
        Add("DockLeft", Icon.DockLeft);
        Add("DockRight", Icon.DockRight);
        Add("DockBottom", Icon.DockBottom);
        Add("Remote", Icon.Remote);
        Add("Refresh", Icon.Refresh);
        Add("Rotate", Icon.Rotate);
        Add("Shuffle", Icon.Shuffle);
        Add("List", Icon.List);
        Add("Shop", Icon.Shop);
        Add("SelectAll", Icon.SelectAll);
        Add("Orientation", Icon.Orientation);
        Add("Import", Icon.Import);
        Add("ImportAll", Icon.ImportAll);
        Add("BrowsePhotos", Icon.BrowsePhotos);
        Add("WebCam", Icon.WebCam);
        Add("Pictures", Icon.Pictures);
        Add("SaveLocal", Icon.SaveLocal);
        Add("Caption", Icon.Caption);
        Add("Stop", Icon.Stop);
        Add("ShowResults", Icon.ShowResults);
        Add("Volume", Icon.Volume);
        Add("Repair", Icon.Repair);
        Add("Message", Icon.Message);
        Add("Page", Icon.Page);
        Add("CalendarDay", Icon.CalendarDay);
        Add("CalendarWeek", Icon.CalendarWeek);
        Add("Calendar", Icon.Calendar);
        Add("Character", Icon.Character);
        Add("MailReplyAll", Icon.MailReplyAll);
        Add("Read", Icon.Read);
        Add("Link", Icon.Link);
        Add("Account", Icon.Account);
        Add("ShowBcc", Icon.ShowBcc);
        Add("HideBcc", Icon.HideBcc);
        Add("Cut", Icon.Cut);
        Add("Attach", Icon.Attach);
        Add("Paste", Icon.Paste);
        Add("Filter", Icon.Filter);
        Add("Copy", Icon.Copy);
        Add("Emoji", Icon.Emoji);
        Add("Important", Icon.Important);
        Add("MailReply", Icon.MailReply);
        Add("SlideShow", Icon.SlideShow);
        Add("Sort", Icon.Sort);
        Add("Manage", Icon.Manage);
        Add("AllApps", Icon.AllApps);
        Add("DisconnectDrive", Icon.DisconnectDrive);
        Add("MapDrive", Icon.MapDrive);
        Add("NewWindow", Icon.NewWindow);
        Add("OpenWith", Icon.OpenWith);
        Add("ContactPresence", Icon.ContactPresence);
        Add("Priority", Icon.Priority);
        Add("GoToToday", Icon.GoToToday);
        Add("Font", Icon.Font);
        Add("FontColor", Icon.FontColor);
        Add("Contact", Icon.Contact);
        Add("Folder", Icon.Folder);
        Add("Audio", Icon.Audio);
        Add("Placeholder", Icon.Placeholder);
        Add("View", Icon.View);
        Add("SetLockScreen", Icon.SetLockScreen);
        Add("SetTile", Icon.SetTile);
        Add("ClosedCaption", Icon.ClosedCaption);
        Add("StopSlideShow", Icon.StopSlideShow);
        Add("Permissions", Icon.Permissions);
        Add("Highlight", Icon.Highlight);
        Add("DisableUpdates", Icon.DisableUpdates);
        Add("UnFavorite", Icon.UnFavorite);
        Add("UnPin", Icon.UnPin);
        Add("OpenLocal", Icon.OpenLocal);
        Add("Mute", Icon.Mute);
        Add("Italic", Icon.Italic);
        Add("Underline", Icon.Underline);
        Add("Bold", Icon.Bold);
        Add("MoveToFolder", Icon.MoveToFolder);
        Add("LikeDislike", Icon.LikeDislike);
        Add("Dislike", Icon.Dislike);
        Add("Like", Icon.Like);
        Add("AlignRight", Icon.AlignRight);
        Add("AlignCenter", Icon.AlignCenter);
        Add("AlignLeft", Icon.AlignLeft);
        Add("Zoom", Icon.Zoom);
        Add("ZoomOut", Icon.ZoomOut);
        Add("OpenFile", Icon.OpenFile);
        Add("OtherUser", Icon.OtherUser);
        Add("Admin", Icon.Admin);
        Add("Street", Icon.Street);
        Add("Map", Icon.Map);
        Add("ClearSelection", Icon.ClearSelection);
        Add("FontDecrease", Icon.FontDecrease);
        Add("FontIncrease", Icon.FontIncrease);
        Add("FontSize", Icon.FontSize);
        Add("CellPhone", Icon.CellPhone);
        Add("ReShare", Icon.ReShare);
        Add("Tag", Icon.Tag);
        Add("RepeatOne", Icon.RepeatOne);
        Add("RepeatAll", Icon.RepeatAll);
        Add("OutlineStar", Icon.OutlineStar);
        Add("SolidStar", Icon.SolidStar);
        Add("Calculator", Icon.Calculator);
        Add("Directions", Icon.Directions);
        Add("Target", Icon.Target);
        Add("Library", Icon.Library);
        Add("PhoneBook", Icon.PhoneBook);
        Add("Memo", Icon.Memo);
        Add("Microphone", Icon.Microphone);
        Add("PostUpdate", Icon.PostUpdate);
        Add("BackToWindow", Icon.BackToWindow);
        Add("FullScreen", Icon.FullScreen);
        Add("NewFolder", Icon.NewFolder);
        Add("CalendarReply", Icon.CalendarReply);
        Add("UnSyncFolder", Icon.UnSyncFolder);
        Add("ReportHacked", Icon.ReportHacked);
        Add("SyncFolder", Icon.SyncFolder);
        Add("BlockContact", Icon.BlockContact);
        Add("SwitchApps", Icon.SwitchApps);
        Add("AddFriend", Icon.AddFriend);
        Add("TouchPointer", Icon.TouchPointer);
        Add("GoToStart", Icon.GoToStart);
        Add("ZeroBars", Icon.ZeroBars);
        Add("OneBar", Icon.OneBar);
        Add("TwoBars", Icon.TwoBars);
        Add("ThreeBars", Icon.ThreeBars);
        Add("FourBars", Icon.FourBars);
        Add("Scan", Icon.Scan);
        Add("Preview", Icon.Preview);
        Add("GlobalNavigationButton", Icon.GlobalNavigationButton);
        Add("Share", Icon.Share);
        Add("Print", Icon.Print);
        Add("XboxOneConsole", Icon.XboxOneConsole);
    }
}

