﻿namespace Business.Request.Fuel
{
    public class UpdateFuelRequest
    {
        public string Name { get; set; }
        public UpdateFuelRequest(string name)
        {
            Name = name;
        }
    }
}
