﻿// <auto-generated />
using BlazorServer.StrategyPatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.StrategyPatternExample.Migrations
{
    [DbContext(typeof(StrategyPatternContext))]
    [Migration("20231227222822_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");
#pragma warning restore 612, 618
        }
    }
}