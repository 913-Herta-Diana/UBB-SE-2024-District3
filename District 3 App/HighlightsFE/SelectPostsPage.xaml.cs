﻿using District_3_App.Enitities.Mocks;
using District_3_App.ProfileSocialNetworkInfoStuff.entities;
using District_3_App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace District_3_App.HighlightsFE
{
    public class PhotoInfo
    {
        public string FilePath { get; set; }
        public Guid PostId { get; set; }
        public string Description { get; set; }

        public PhotoInfo(string filePath, Guid postId)
        {
            FilePath = filePath;
            PostId = postId;
        }
    }
    public partial class SelectPostsPage : UserControl
    {
        private List<PhotoInfo> photosInfo = new List<PhotoInfo>();
        private List<Guid> selectedPostsGuids = new List<Guid>();
        HighlightsRepo highlightsRepo = new HighlightsRepo();
        public SelectPostsPage()
        {
            InitializeComponent();
            List<MockPhotoPost> posts = highlightsRepo.GetConnectedUserPosts(new User());

            foreach (MockPhotoPost post in posts)
            {
                var photoInfo = new PhotoInfo(post.getPhoto(), post.getPostId());
                photosInfo.Add(photoInfo);
            }

            DataContext = photosInfo;
        }
        private void CheckBox_Loaded(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            PhotoInfo photoInfo = (PhotoInfo)checkBox.DataContext;
            checkBox.Name = "CheckBox_" + photoInfo.PostId.ToString().Replace("-", "_");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string checkBoxName = checkBox.Name;
            if (checkBoxName.StartsWith("CheckBox_"))
            {
                string photoGuid = checkBoxName.Replace("CheckBox_", "");
                photoGuid = photoGuid.Replace("_", "-");
                if (!selectedPostsGuids.Contains(Guid.Parse(photoGuid)))
                {
                    selectedPostsGuids.Add(Guid.Parse(photoGuid));
                }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string checkBoxName = checkBox.Name;
            if (checkBoxName.StartsWith("CheckBox_"))
            {
                string photoGuid = checkBoxName.Replace("CheckBox_", "");
                photoGuid = photoGuid.Replace("_", "-");
                if (selectedPostsGuids.Contains(Guid.Parse(photoGuid)))
                {
                    selectedPostsGuids.Remove(Guid.Parse(photoGuid));
                }
            }
        }

        private void SubmitPostsButton_Click(object sender, RoutedEventArgs e)
        {
            SelectHighlight selectHighlight = new SelectHighlight(selectedPostsGuids);
            selectHighlight.ShowDialog();

        }
    }
}
