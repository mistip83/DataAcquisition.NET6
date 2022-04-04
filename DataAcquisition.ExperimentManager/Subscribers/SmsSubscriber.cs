using System;
using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Subscribers;

public class SmsSubscriber : ISubscriber
{
    private readonly IPublisher _experimentStatePublisher;

    public SmsSubscriber(IPublisher experimentStatePublisher)
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
        // TODO: send sms to mobile
        Console.WriteLine($"ExperimentStatus: {e.ExperimentState}");
    }
}