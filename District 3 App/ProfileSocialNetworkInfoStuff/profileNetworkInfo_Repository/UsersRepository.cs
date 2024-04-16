﻿using District_3_App.ProfileSocialNetworkInfoStuff.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace District_3_App.ProfileSocialNetworkInfoStuff.profileNetworkInfo_Repository
{
    public class UsersRepository
    {
        public List<User> usersRepositoryList { get; set; }

        private string filePath;

        public UsersRepository() { }
        public UsersRepository(List<User> usersRepositoryList) { this.usersRepositoryList = usersRepositoryList; }
        public UsersRepository(string filePath) 
        { 
            this.filePath = filePath;
            LoadUsersFromXml();
        }

        //private void LoadUsersFromXml() 
        //{
        //    usersRepositoryList = new List<User>();
        //    XDocument xDocument = XDocument.Load(filePath);
        //    var users = xDocument.Descendants("User");
        //    foreach (var user in users)
        //    {
        //        User newUser = new User
        //        {
        //            id = (Guid)user.Attribute("id"),
        //            username = (string)user.Attribute("username"),
        //            email = (string)user.Attribute("email"),
        //            password = (string)user.Attribute("password"),
        //            confirmationPassword = (string)user.Attribute("confirmationPassword")
        //        };
        //        usersRepositoryList.Add(newUser);
        //    }


        //}
        private void LoadUsersFromXml()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                // Handle null or empty file path
                Console.WriteLine("File path is null or empty.");
                return;
            }

            try
            {
                usersRepositoryList = new List<User>();

                XDocument xDocument = XDocument.Load(filePath);
                var users = xDocument.Descendants("User");

                foreach (var user in users)
                {
                    User newUser = new User
                    {
                        id = (Guid)user.Attribute("id"),
                        username = (string)user.Attribute("Username"),
                        email = (string)user.Attribute("Email"),
                        password = (string)user.Attribute("Password"),
                        confirmationPassword = (string)user.Attribute("ConfirmationPassword"),
                        followingCount = (int)user.Attribute("Following"),
                        followersCount = (int)user.Attribute("Followers")
                    };

                    usersRepositoryList.Add(newUser);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while loading users from XML: " + ex.Message);
            }
        }


        private void saveUsersToXml()
        {
            XDocument xDocument = new XDocument(
               new XElement("UserAccounts",
                   usersRepositoryList.Select(user =>
                       new XElement("User",
                           new XAttribute("id", user.id),
                           new XAttribute("Username", user.username),
                           new XAttribute("Email", user.email),
                           new XAttribute("Password", user.password),
                           new XAttribute("ConfirmationPassword", user.confirmationPassword),
                            new XElement("Following", user.followingCount), 
                            new XElement("Followers", user.followersCount)
                           )
                   )
               )
           );

           xDocument.Save(filePath);
        }

        public User GetUserByName(string username)
        {
            foreach (var user in usersRepositoryList)
            {
                if (user.username == username) return user;
            }

            return null;
        }

        public List<User> GetAllUsers() { return usersRepositoryList; }

        public void AddUser(User user)
        {
            usersRepositoryList.Add(user);
            saveUsersToXml();
        }
        public int getFollowersCount(string username)
        {
            User user = GetUserByName(username);
            if (user != null)
            {
                return user.followersCount;
            }
            else
            {
                // Handle user not found scenario
                return -1; 
            }
        }
        public int getFollowingCount(string username)
        {
            User user = GetUserByName(username);
            if (user != null)
            {
                return user.followingCount;
            }
            else
            {
                // Handle user not found scenario
                return -1; 
            }
        }
    }
}
