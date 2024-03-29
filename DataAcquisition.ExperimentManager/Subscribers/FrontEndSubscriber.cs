﻿using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Subscribers;

public class FrontEndSubscriber : ISubscriber
{
    private readonly IPublisher _experimentStatePublisher;

    public FrontEndSubscriber(IPublisher experimentStatePublisher)
    {
        _experimentStatePublisher = experimentStatePublisher;
    }

    public void Subscribe()
    {
        _experimentStatePublisher.OnExperimentProcessed += Update;
    }

    public void UnSubscribe()
    {
        _experimentStatePublisher.OnExperimentProcessed -= Update;
    }

    private static void Update(object sender, IExperimentProcessedEvent e)
    {
        // TODO: send state to UI
        Console.WriteLine($"ExperimentStatus: {e.ExperimentState}");
    }
}