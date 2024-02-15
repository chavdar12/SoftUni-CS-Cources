﻿using Ex007.Enumerators;
using Ex007.Interfaces;

namespace Ex007.Models;

public class Mission : IMission
{
    private MissionState state;

    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }

    public string CodeName { get; }

    public string State
    {
        get => state.ToString();

        private init
        {
            MissionState state;

            if (!Enum.TryParse(value, out state)) throw new ArgumentException();

            this.state = state;
        }
    }

    public void CompleteMission()
    {
        state = MissionState.Finished;
    }

    public override string ToString()
    {
        return $"   Code Name: {CodeName} State: {State}";
    }
}