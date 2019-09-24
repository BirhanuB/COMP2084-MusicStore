﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using COMP2084_MusicStore.Models;

namespace COMP2084_MusicStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World from Store.Index()");
            /*return View();*/
        }
        public IActionResult Browse(string genre)
        {
            genre = HttpUtility.HtmlEncode("Store.Browse, genre = " + genre);
            return Ok(genre);
            /*return View();*/
        }
        public IActionResult Details(int id)
        {
            return Ok(id.ToString());
            /*return View();*/
        }
        public IActionResult Albums()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Name = "Album" + i.ToString() });
            }
            return View(albums);
        }
    
    }

}