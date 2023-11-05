class ReflectionActivity : Activity
{
    // Prompts:
    List<string> prompts = new()
{
    "Reflect on a moment when you felt extremely proud of yourself.",
    "Remember a situation where you had to be brave.",
    "Recall a memory when you made someone smile.",
    "Think about a time you went out of your way to be kind.",
    "Consider a moment when you learned a valuable lesson from a mistake.",
    "Contemplate a situation where you overcame a personal challenge.",
    "Recall a time when you had to adapt to a significant change.",
    "Reflect on an instance when you had to make a tough decision.",
    "Think about a moment when you offered forgiveness.",
    "Remember a time when you were grateful for someone's help.",
    "Consider a situation when you mentored or taught someone something important.",
    "Think of a time when you received a compliment that meant a lot to you.",
    "Recall a moment when you felt at peace with yourself.",
    "Reflect on a time when you contributed to a community or group effort.",
    "Contemplate a situation where you showed patience.",
    "Remember a time when you were recognized for your efforts.",
    "Think about a moment when you reached a personal goal.",
    "Consider a time when you gave someone a meaningful gift.",
    "Recall a situation where you showed empathy to someone else.",
    "Think of an occasion where you stood by a friend in a difficult time.",
    "Reflect on a moment when you were inspired by someone's actions or words.",
    "Contemplate a time when you saw beauty in an ordinary moment.",
    "Remember a situation where you made a positive impact on the environment.",
    "Consider an instance when you were the peacekeeper in a conflict.",
    "Think of a time when you expressed love in a unique way.",
    "Reflect on a moment when you were able to forgive yourself.",
    "Recall a time when you took the initiative on a project or idea.",
    "Think about a situation where you showed courage in the face of fear.",
    "Remember a moment when you made a significant change for your health.",
    "Contemplate a time when you supported someone's dreams or goals.",
    "Consider an occasion when you connected with someone from a different background or culture.",
    "Reflect on a situation where you had a meaningful conversation.",
    "Think of a time when you were genuinely happy for someone else's success.",
    "Remember an instance when you returned a lost item to its owner.",
    "Consider a moment when you went above and beyond expectations.",
    "Recall a situation where you had to navigate a difficult conversation.",
    "Contemplate a time when you were resilient in the face of setbacks.",
    "Reflect on a moment when you created something you were proud of.",
    "Think about an instance when you contributed to someone else's happiness.",
    "Remember a time when you committed to a personal project or hobby.",
    "Consider a situation where you helped an animal or took care of a pet.",
    "Think of a moment when you learned something new about yourself.",
    "Recall a time when you listened more than you spoke.",
    "Reflect on a situation where you stood firm on an important issue.",
    "Contemplate a time when you experienced joy in simple pleasures.",
    "Remember an occasion when you made a sacrifice for the greater good.",
    "Consider a moment when you felt a strong connection to nature.",
    "Think of a situation where you spread positivity in your community.",
    "Recall a time when you had to persevere through hard work.",
    "Reflect on an instance when you made a stranger's day better."
};


    // Questions:
    List<string> questions = new()
{
    "What steps did you take to overcome obstacles during this experience?",
    "Can you identify any turning points during the event that were critical to its outcome?",
    "How have your thoughts or feelings about the activity changed since you started?",
    "Who or what was most influential in guiding you through this experience?",
    "What personal values were reinforced or challenged through this experience?",
    "How might this experience influence your future actions or decisions?",
    "What advice would you give someone else based on your experience?",
    "In what ways did this experience stretch your comfort zone?",
    "How did others' feedback or reactions impact your experience?",
    "What was the most unexpected part of this experience?",
    "How did this experience align with your expectations?",
    "Were there any moments of epiphany or significant insight during this experience?",
    "How did you balance your personal emotions and objectives during the experience?",
    "What resources proved to be the most valuable during this experience?",
    "How did this experience connect to your overall life journey?",
    "What was the biggest risk you took during this experience?",
    "How did you measure success during this process?",
    "In what ways did teamwork or collaboration play a role in this experience?",
    "What would you do differently if you were to repeat this experience?",
    "How did you maintain motivation throughout the experience?",
    "What role did planning or strategy play in the outcome?",
    "How did you adapt to any changes or surprises during the experience?",
    "What were some key takeaways from this experience that you didn't anticipate?",
    "How did you ensure that your actions remained aligned with your goal?",
    "What techniques or methods did you employ to stay focused?",
    "How did this experience contribute to your personal or professional growth?",
    "What was the most challenging part of the experience, and how did you handle it?",
    "How has this experience influenced your perception of yourself or others?",
    "What did you find most rewarding about the experience?",
    "How did you celebrate or reflect upon your achievements?",
    "What role did perseverance play in your experience?",
    "How did you manage stress or pressure during this experience?",
    "In what ways did this experience test your limits or capabilities?",
    "How did you make use of your strengths during this experience?",
    "What impact do you think this experience has had on those around you?",
    "How has this experience shaped your future goals or aspirations?",
    "What was the role of creativity or innovation in this experience?",
    "How did this experience enhance your understanding of a particular subject or skill?",
    "What strategies did you use to overcome self-doubt during this experience?",
    "How did you ensure that you were making progress towards your objectives?",
    "What have you added to your personal toolbox of skills or knowledge as a result of this experience?",
    "How did you deal with failure or setbacks during this experience?",
    "What was the most surprising feedback you received, and how did you respond to it?",
    "How did you manage the balance between personal expectations and external demands?",
    "How did this experience solidify your values or beliefs?",
    "What aspects of this experience would you like to explore further?"
};


    public void Reflecting(){
        Console.WriteLine($"Think about the following prompt for {durationTime} seconds, and list as many things as you can. \nPress enter after each one.");
        Console.WriteLine(RandomItem(prompts));
        Spinner(5);
        while(DateTime.Now < GetActivityEnd())
        {
            Console.WriteLine($"\t{RandomItem(questions)}");
            Spinner(15);
        }

    }

}

