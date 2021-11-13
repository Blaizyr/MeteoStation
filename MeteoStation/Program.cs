{
    MeteoStation.ModuleData pogoda = new MeteoStation.ModuleData(); // utworzenie obiektu w main wymaga eksplicytnego wskazania namespace. Przez zmiany składni w .Net 6.0?
    MeteoStation.ModuleStats statystyki = new MeteoStation.ModuleStats();
    MeteoStation.ModuleForecast prognoza = new MeteoStation.ModuleForecast();

    MeteoStation.WeatherData weatherData = new MeteoStation.WeatherData();
    weatherData.RegisterObserver(pogoda);
    weatherData.SetReadings(29.31f, 79.5f, float.MaxValue);

    pogoda.Display();


    
}