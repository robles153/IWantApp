﻿using IWantApp.Infra.Data;

namespace IWantApp.EndPoints.Categories
{
    public class CategoryPost
    {
        public static string Template => "/categories";
        public static string[] Methods = > new string[] { HttpMethod.Post.ToString() };
        public static Delegate Hendle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
        {
            return Results.Ok("OK Teste");
        }
    }
}
