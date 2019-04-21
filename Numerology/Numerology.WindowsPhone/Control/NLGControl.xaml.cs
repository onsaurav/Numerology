using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Numerology.Control
{
    public sealed partial class NLGControl : UserControl
    {
        Common common = new Common();
        public NLGControl(string label = "")
        {
            this.InitializeComponent();

            if (!String.IsNullOrEmpty(label))
                tblCaption.Text = label + " (For day, month and year use number)";
        }
        
        private void txtText_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtnum.Text = common.GetNumber(txtText.Text).ToString();
        }

        private string GetNumberDetails(string NumberText)
        {
            int num = 0;
            string text = string.Empty;
            int.TryParse(NumberText, out num);

            if (num == 1)
            {
                text = @"In Numerology, each of the nine single-digit numbers has a personality -- a limited range of qualities and traits that makes it unique and recognizable. To me each number is a character, like any human being. In order to understand how numbers affect us based on their location in the chart, it helps to get to know each single digit number as if it were a person. The goal is to get beyond each number being just a list of positive and negative qualities and to, instead, make each number come alive -- to sense how the numbers play off of each other. If you sense some exaggeration in my descriptions, remember that these nine 'individuals' are extremes by their very nature (while we, as human beings, are made up of a mixture of all the numbers' traits). Among the nine single-digit numbers, the 1 takes a special place. From a spiritual perspective, it is the number of creation, the primal force from which all other numbers spring forth (as opposed to the often quoted zero from which, by definition, nothing could possibly come into being). It is said that when you truly understand the place and function of this most primal of all numbers, you will know all there is to know and enlightenment is yours. This statement, of course, does not apply to an understanding of the number 1 from a Numerologist's perspective alone, but perhaps that is a good place to start, as the personality of the number 1 aligns nicely with its more elevated spiritual symbolism. The 1 is a doer, a powerful force that produces results and does not allow anything or anyone to limit its potential. The 1 is aggressive, a necessary energy for creating and producing. The 1 is always in the forefront: a spearpoint directing and leading others. The shape of the number 1, just like the shape of all other symbols, reflects its meaning; it walks upright with pride and purpose. Strong, determined, unwavering and with specific goals in mind, the 1 can turn dreams and ideas into reality. It pushes obstacles aside or simply drills right through them. The 1 grows, transforms and improves in perpetuity, precisely the way Mother Nature does. After all, nature's primal force and most basic building block is the number 1. Nature knows no mercy and its cruelty can be heartbreaking. However, it knows balance and gives life indiscriminately and without judgment. Scientists sometimes compete with nature, genetically altering fruits or breeding bugs for specific purposes. An understanding of nature teaches us that this is never a good idea and almost always produces unexpected backlashes. The number 1 has a similar built-in perfection and balance; you can force a change here or there, but negative repercussions are likely. The 1 tends to have a simple, straightforward view of life and its many complexities. It trusts its own ability to separate right from wrong. It doesn't waste time on abstract ideas or anything else that isn't in line with its pursuit of results. The 1 is no preacher, no philosopher, no spiritual explorer, no dreamer and certainly not an idealist. It is a pragmatist, a ruthless conqueror and a warrior extraordinaire. It is individualistic and independent to a fault. It will attempt to force its values and opinions on you but it won't accept, or even listen to, yours. The 1 does not hesitate when it senses a need for confrontation. It is jealous and extremely stubborn, but also courageous and willing to try anything new if it sees promise, even at great danger. It is, if you haven't guessed, the most masculine of all numbers. There is a certain quality, a sense of honor and responsibility that demands our respect, and it has a sense of justice that cannot be denied. The number 1 cannot witness injustice without jumping in and setting things straight. Its purity of purpose is an admirable quality of the number 1. It sees things for what they are and hypocrisy doesn't stand a chance. Befriend a 1 and you have a friend for life. You can poke fun at a 1 and not have to worry about hurt feelings. A 1 has a great capacity for humor, including the self-deprecating kind. If, however, you try to cater to a 1 to win its love or friendship, you'll lose its respect instead. Stand up to a 1 and you may lose the fight, but you'll gain its admiration. If you are in trouble and need help, the number 1 is who you want on your side -- there is no more dedicated protector or braver partner. If you are in love, the number 1 is the most difficult of all lovers: demanding, jealous, confrontational and impatient. If you find yourself in the service of a 1, you will be pushed to the limit, abused at all hours, and incapable of living up to its expectations. But you will also, without a doubt, become the best you could ever be. If the 1 is your enemy, you will be crushed without mercy. If you yourself are a 1, your happiness and satisfaction will come from your work more than from any other source. And if it was possible for a person to be fully and truly a 1 and only a 1, that individual would be successful and intimidating, as well as extremely unpleasant and dangerous.";
            }
            else if (num == 2)
            {
                text = @"As the most feminine among all numbers, the 2 is also the most underestimated -- at least, when it comes to power and strength. After all, she is almost always gentle, tactful, diplomatic, forgiving and understanding. Certainly, she likes to keep the peace and will avoid confrontations as much as possible.If you look at the shape of the 2, however, you will recognize a symbolic representation of the ultimate survivor and an extremely resilient force. Her shape, as if bent on a knee with her head and back bowed in humility and servitude, makes it easy to dismiss her as weak and powerless. This is in stark contrast to the power and pride of the mighty and masculine 1, who will not bow for anyone at any price. However, when enough pressure is applied to the powerful warrior we see in the number 1, he will break and shatter and be done with.On the other hand, when the humble and feminine 2 finds herself under attack and burdened with a crushing weight, she will bend, she will bend as much as needed. And when the weight is removed, her elastic, flexible nature allows her to come right back up, seemingly with little harm done, and she will continue to play her role.Her strength and power is resilient and lasting, just as the shape of the number 2 reflects that so beautifully. There is much more to her than meets the eye; she is often the true power behind the throne. As we stand in awe to the leadership and decisive actions of the 1, his strength and cunning relies on the clever and insightful advice of his greatest ally, the number 2.Unnoticed and operating from the shadows, she is the Mata Hari who outwits other spies and diplomats with her grace, her sensuality, her flattering attention and her gentle force of persuasion. She is smart and understands the underlying qualities that make people do this or do that. A born psychologist, there is not much about human nature that escapes her. She often controls the outcome of certain events without anyone else noticing or acknowledging. In fact, the credit quite often goes to some other entity when it should be hers. This does not bother her, because among her best qualities is patience. She knows her time will come. But even if she does not always get the recognition she deserves, she tends to take a special place in the hearts and minds of others due to her sophistication, her grace, her style and her excellent taste in art and music.The 2 has an in-born sense of music and rhythm that makes her popular among any social crowd, and it is in the lighthearted arena of play and art that she shines as a dancer and a conversationalist. Within a social environment, perhaps her most important asset is a sense of humor that is witty and self-depreciating, but never slapstick or juvenile, as she is far too sophisticated for that.If the Greek god Zeus could be compared to the number 1, then his wife and sister Hera would represent the number 2. And like Hera, the number 2 is jealous and mean-spirited when other forces reach for her man. Because as gentle and loving as she is most of the time, her anger is formidable and another side of her comes out when she feels crossed or mistreated -- a side that can be mean and vengeful, cruel and unrelenting. She will claw her adversary to pieces and never look back in regret or remorse. What is hers is hers, and you are well-advised to remember that, as many Greek gods and half-gods found out the hard way.As a partner, the number 2 is an invaluable asset. She will defend you at any cost and her loyalty is unshakeable. However, she is emotional and demanding, and expects to be treated like a princess. She is devoted to you, but she also expects you to be devoted to her. At times, she is a true drama queen, and when that happens you may know for sure that you have not paid enough attention lately. She is not particularly materialistic, but if you don't show up with gifts or flowers every once in a while, she will let you know in no uncertain terms that you are not measuring up. She will throw the occasional tantrum, but if you respond with love and attention she will make it up to you in proper fashion.In short, the number 2 is a sensual, graceful, loyal partner who can be a bit demanding, but is worth the trouble. And there is another important aspect to the number 2. As the most intuitive of all single-digit numbers, she is drawn to the occult (only the double-digit 11 surpasses her in that department). However, the real value of her intuitive prowess is in the way she interacts with others; it is the true basis of her tact and understanding. Like a good politician, which she can certainly be if needed, she often understands the true motivations of others better than they do, and her clarity and her powers of observation often help others to understand themselves better.On top of her jealousy, her vengeful nature when she feels mistreated and her cruelty when punishing adversaries, the 2 can also be critical and verbally abusive. Her ability to pout and sulk, her bouts of bad temper for trivial reasons and her extended periods of indifference can drive any sane person crazy. On top of that, she is capable of displaying the most illogical reasoning, and a verbal argument can feel like trying to slice water with a knife; nothing you say seems to have any effect. Generally, the best thing to do when a 2 behaves like that is to get out of her way for a while -- and then reappear with a big bouquet of flowers, and smile like nothing ever happened.";
            }
            else if (num == 3)
            {
                text = @"Each of the numbers 1 through 9 has a unique personality, a limited range of qualities and traits. To get a good understanding of how numbers affect us, it helps to get to know each single-digit number as if it were a person you know, carrying its own personality traits, strengths and weaknesses.I have described the unique union between the numbers 1 and 2 as that of the father and mother unit, while revealing the extreme contradictory natures of each of their personalities. Now, we move on to what could be considered the result of their union: the number 3, an extraordinarily talented child.The number 3 is like a gifted teenager who is still under the protection of its parents: a bit spoiled, certainly scattered and perpetually in need of guidance. However, the most obvious traits of the 3 are in the creative field. A powerful need to express feelings, ideas and visions of the imagination, coupled with an extroverted personality, makes it likely that a person with 3s in key points of their Numerology chart will seek a career in art, especially the verbal arts. His or her social skills are also excellent. Charm, wit and a sense of humor help a 3 individual along his or her path, and if that weren't enough, good looks and compelling charisma make this 'kid' particularly attractive.No wonder so many are drawn to those with 3s in their charts. Followers are even willing to forgive less favorable traits exhibited by 3s, like a lack of focus and direction, a tendency to procrastinate, an inability to finish projects and an unwillingness to take responsibility. On the other hand, there is a superficial side to the 3 that can be harder to look past: a narcissistic streak, a vanity, a need to be the center of attention. It is easy for the optimistic 3 to enjoy day-to-day life as long as all is well, but when challenging issues arise, it can become quickly apparent that most of the 3's focus has been on that sunny exterior, leaving its internal fortitude lacking. Without much moral strength or spiritual depth, a 3 can easily succumb to difficulties unless friends and family move in to support it.For the 3 to become a well-rounded, balanced and happy person, it must learn discipline. Some lucky 3s who exhibit talent early in life (such as gifted dancers or musical prodigies) are placed in an environment with just the sort of discipline that a 3 needs to protect these talents. Another unique quality of the 3 is its tendency to be 'lucky,' or rather, to be in the right place at the right time. This may be connected to its innate sense of rhythm; timing can be measured in seconds or in years, by the beating of a heart or by the movement of the stars. It is all only a matter of scale, either way, the 3 seems to be in tune with the cyclical nature of our surroundings.Relationships are a bit of a challenge for the 3 -- at least those that include long-term commitment and loyalty. With plenty of acquaintances (probably more than is healthy), when true depth and intimacy enters the picture, this 'kid' turns tail and runs. The 3 has a nasty jealous streak, too, causing conflicts when those it has rejected move on in search of more meaningful bonds. This jealousy stems from the fact that the 3 knows, deep down inside, that it has only been skimming the surface of life since birth. As a result, the 3 feels a deeply hidden sense of insecurity, a sense that others know things that have thus far escaped the 3. This is not entirely incorrect and, when confronted with this reality, it leaves the 3 devastated and helpless.There is perhaps nothing more painful than to watch the sunny, buoyant 3 crash into a vulnerable heap of self-pity. And yet, this can be the best thing ever to happen to this shallow creature, as this sometimes represents a turn-around. Once a 3 finds the motivation and enthusiasm to dig deeper into the realities of life (something that will only happen when it has had to confront itself), its happy surface has the potential to be replaced by the quiet serenity that only true wisdom brings. Such a 'transformed' 3, rare as it is, is truly a thing to behold.No human being is ever represented by just one number, but rather is a mixture of several, if not all, of the numbers. Those who have been blessed with a heavy dose of 3s in their charts tend to have an easier time being happy, optimistic and playful creatures. However, this kind of 'joie de vivre' can leave those same people unprepared for the more demanding experiences that life inevitably brings. And while the western mindset focuses on happy moments as the ideal, the unhappy experiences can be the ones that bring a much greater depth and quality to our lives.For the number 3, happiness may be easy to achieve, but is almost always a consequence of something materialistic or fleeting (a new car, a new relationship, a sunny day, etc.). A higher happiness, one that is not a consequence of any particular event but is truly the result of a deep appreciation towards life itself, is worth a million times more than the aforementioned shallow kind. The biggest challenge for the number 3 is to recognize this, to learn that the real beauty of life is found not in our possessions or illusions, but rather is hidden inside our fellow human beings. After all, it is being human that allows us the potential to experience what has been called the impossible achievement: to enter the realm where the mortal and the immortal meet.If the 3 can ever defy the odds to achieve this rare and amazing state of being, the fact that it has had to travel so far to reach such a height makes this number uniquely qualified to guide and help others reach the same goal.";
            }
            else if (num == 4)
            {
                text = "";
            }
            else if (num == 5)
            {
                text = "";
            }
            else if (num == 6)
            {
                text = "";
            }
            else if (num == 7)
            {
                text = "";
            }
            else if (num == 8)
            {
                text = "";
            }
            else if (num == 9)
            {
                text = "";
            }

            return text;
        }

        private async void Border_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (txtnum.Text.Trim().Equals(string.Empty) || txtnum.Text.Trim().Equals("0"))
            {
                MessageDialog msg = new MessageDialog("Number is not between 1 to 9?", "Ops!");
                await msg.ShowAsync();
            }
            else
            {
                if (!StandardPopup.IsOpen)
                    StandardPopup.IsOpen = true;

                txtPopUp.Text = GetNumberDetails(txtnum.Text);
            }
        }

        private void btnpopupClose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (StandardPopup.IsOpen)
                StandardPopup.IsOpen = false;
        }
    }
}
