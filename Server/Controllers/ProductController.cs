﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ginkgotree.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Green Tea",
                Description = "Should there ever be an official hall of fame for the world’s top teas, This green tea certainly would belong right up there with the other special teas of the world. It was originally grown in Fujian Province in China on steep mountain sides.  This tea has also adopted the name ‘Monkey Picked Tea’ because it was believed that only trained monkeys could reach the plants and pick them. Unfortunately this was probably not the case. Even today it is still a very labour intensive tea and can only be picked for a short season. What also makes this tea so special is the gentle and mild character of the liquor and the high percentage of ‘fluffy’ tips. It is often therefore compared to a delicious white tea. This is a must for every green tea lover.",
                ImageUrl = "images/greentea.png",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Black Tea",
                Description = "This rare black tea is from the Fujian province of China. Golden Monkey tea is hand-processed each spring with a careful plucking of only one leaf and bud. It is among the finest Chinese black teas available today. The name comes from its unique appearance as the leaves resemble monkey tails. If you enjoy full-bodied teas with an abundance of flavour we recommend you give this tea a try. It is also fabulous with milk.This tea has a place in our hearts, and cupboards, so much that our cherished shop was named after it. Now that's love.",
                ImageUrl = "images/blacktea.png",
                Price = 7.99m
            },
            new Product
            {
                Id = 3,
                Title = "Ooolong Tea",
                Description = "Formosa, meaning ‘beautiful’ and the former name of Taiwan, describes a blend of oolong produced in Taiwan, an island famous for the production of this type of tea. Originally introduced by the Chinese in the mid to late 1800s, it is now said that the Taiwanese have perfected this type of tea production. Our Formosa oolong is about 50% oxidised which is half way between a green and a black tea. The result is a  mild, flowery and spicy infusion refreshing enough to quench any thirst.  No milk needed. ",
                ImageUrl = "images/oolongtea.png",
                Price = 11.99m
            }
        };


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }

    }
}
