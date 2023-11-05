class BreathingActivity : Activity
{
    private int breathingTime = 7;
    public void Breathing()
    {
        while(DateTime.Now < GetActivityEnd())
        {
            MessageWithDelay("Breathe in", breathingTime);

            MessageWithDelay("Breathe out", breathingTime);

            breathingTime += 1;
        }
    }
}