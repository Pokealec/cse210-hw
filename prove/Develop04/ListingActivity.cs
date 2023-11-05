class ListingActivity : Activity
{
    private List<string> prompts = new()
{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What are some achievements you're proud of?",
    "What kind gestures have you received lately?",
    "What challenges have you overcome?",
    "What moments of happiness have you experienced recently?",
    "What are you looking forward to in the near future?",
    "Who has been kind to you in your life?",
    "What are you grateful for today?",
    "What skills have you improved this year?",
    "Who has taught you valuable lessons in life?",
    "What positive changes have you noticed in yourself?",
    "What acts of kindness can you perform?",
    "How do you plan to achieve your current goals?",
    "What is something new you've learned this week?",
    "Who inspires you to be better?",
    "What are some wise words that resonate with you?",
    "How do you handle stress effectively?",
    "What friendships do you treasure the most?",
    "What are some small things that make your day better?",
    "How have you grown in the last year?",
    "What traditions do you hold dear?",
    "What are your favorite ways to rest and recharge?",
    "What are the most peaceful moments of your day?",
    "How do you show love and support to others?",
    "What hobbies bring you joy?",
    "What books or movies have made an impact on you?",
    "How do you maintain a positive outlook?",
    "What are some life hacks you've found useful?",
    "What memories do you cherish the most?",
    "How do you make your home a happy place?",
    "What things in nature do you find most beautiful?",
    "How do you take care of your mental health?",
    "What goals are you currently working toward?",
    "How do you contribute to your community?",
    "What has been the highlight of your month?",
    "What are your strategies for personal growth?",
    "How do you balance your work and personal life?",
    "What are the most meaningful compliments you have received?",
    "How do you stay fit and healthy?",
    "What new activities or hobbies would you like to try?",
    "What lessons have you learned from your travels?",
    "How do you nurture your spiritual life?",
    "What have been your most rewarding experiences?",
    "How do you celebrate your successes?",
    "What are some self-care practices that you find beneficial?",
    "What are the biggest strengths of your personality?"
};


    private List<string> things = new();

    public void Listing(){
        Console.WriteLine($"Think about the following prompt for {durationTime} seconds, and list as many things as you can. \nPress enter after each one.");
        Console.WriteLine(RandomItem(prompts));
        LoadingBar(5);
        Console.WriteLine("\nGo!");

        while(DateTime.Now < GetActivityEnd())
        {
            Console.Write("Enter: ");
            things.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {things.Count} items! Press enter to continue.");
        Console.ReadLine();
    }
}