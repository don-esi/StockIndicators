//     Ooples Finance Stock Indicator Library
//     https://ooples.github.io/PortfolioManager.StockIndicators/
//
//     Copyright © Franklin Moormann, 2020-2022
//     cheatcountry@gmail.com
//
//     This library is free software and it uses the Apache 2.0 license
//     so if you are going to re-use or modify my code then I just ask
//     that you include my copyright info and my contact info in a comment

global using PortfolioManager.StockIndicators.Enums;
global using PortfolioManager.StockIndicators.Exceptions;
global using PortfolioManager.StockIndicators.Models;
global using static PortfolioManager.StockIndicators.Helpers.MathHelper;
global using static PortfolioManager.StockIndicators.Helpers.SignalHelper;
global using static PortfolioManager.StockIndicators.Helpers.CalculationsHelper;
global using MathNet.Numerics;
global using MathNet.Numerics.Statistics;
global using LinqOptimizer.CSharp;
global using System.Globalization;
global using PortfolioManager.StockIndicators.Helpers;
global using System.Runtime.Serialization;
global using PortfolioManager.StockIndicators.Interfaces;