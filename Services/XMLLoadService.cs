using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using WpfApp6_餐馆点餐系统Demo.Models;

namespace WpfApp6_餐馆点餐系统Demo.Services
{
    class XMLLoadService : IXMLLoadService
    {
        public void LoadDishMenu()
        {
            XDocument xDocument = new XDocument();
            using (XmlReader reader = XmlReader.Create(@"Data\XMLDishMenu.xml"))
            {

            }
        }

        List<Dish> listDishMenu;
    }
}
