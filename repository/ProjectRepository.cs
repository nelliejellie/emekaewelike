using System;
using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;


namespace Portfolio.Repository
{
    public class ProjectRepository
    {
        public static Project zero = new Project
        {
            Title="Nysc Api documentation",
            Description = "api documentation for nyschub",
            Link = "https://nyschub-api.herokuapp.com/api-docs",
            Image = "api-documentation.png",
            BackgroundColor = "orange"
        };
        public static Project one = new Project
        {
            Title="Techstudio Academy",
            Description = "Tachstudios academy bootcamp webapp",
            Link = "https://techstudioacademy.com/",
            Image = "techstudio.png",
            BackgroundColor = "blue"
        };
        public static Project two = new Project
        {
            Title="Staff Management",
            Description = "a staff management project for managing staffs in an organisation",
            Link = "http://staffmanagementcsharp.herokuapp.com/",
            Image = "staffmanagement.png",
            BackgroundColor = "teal"
        };

        public static Project three = new Project
        {
            Title="Transferano",
            Description = "a peer to peer crypto selling application",
            Link = "https://transferexo.herokuapp.com/",
            Image = "transferxo.png",
            BackgroundColor = "blue"
        };

        public static Project four = new Project
        {
            Title="Online Class",
            Description = "an online class for students to register and pick classes to attend",
            Link = "https://nelliejellie.github.io/kodecamptasksix/",
            Image = "classroom.png",
            BackgroundColor = "orange"
        };

        public static Project five = new Project
        {
            Title = "Country Query",
            Description = "a javascript application for checking countries and information accompanying them",
            Link = "https://nelliejellie.github.io/countries_api_query_with_vanilla_js/",
            Image = "countries.png",
            BackgroundColor = "red"
        };

        public static Project six = new Project
        {
            Title = "NyscHub Api",
            Description = "Nysc forum and marketplace api",
            Link = "https://nyschub-api.herokuapp.com/swagger/index.html",
            Image = "nyschub.png",
            BackgroundColor = "orange"
        };
        public List<Project> projects = new List<Project>()
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six
        };
    }
}