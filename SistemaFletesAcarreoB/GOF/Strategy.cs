using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Controlador;

namespace SistemaFletesAcarreoB.GOF
{

    interface IOfferStrategy
    {
        string Name { get; }
        double GetDiscountPercentage();
    }

    /* Concrete implementation of base Strategy */
    class NoDiscountStrategy : IOfferStrategy
    {
        public string Name => nameof(NoDiscountStrategy);

        public double GetDiscountPercentage()
        {
            return 0;
        }
    }
    class QuarterDiscountStrategy : IOfferStrategy
    {
        public string Name => nameof(QuarterDiscountStrategy);

        public double GetDiscountPercentage()
        {
            return 0.25;
        }
    }

    class StrategyContext
    {
        double price;
        Dictionary<string, IOfferStrategy> strategyContext
            = new Dictionary<string, IOfferStrategy>();
        public StrategyContext(double price)
        {
            this.price = price;
            strategyContext.Add(nameof(NoDiscountStrategy),
                    new NoDiscountStrategy());
            strategyContext.Add(nameof(QuarterDiscountStrategy),
                    new QuarterDiscountStrategy());
        }

        public void ApplyStrategy(IOfferStrategy strategy)
        {
            Console.WriteLine("Price before offer :" + price);
            double finalPrice
                = price - (price * strategy.GetDiscountPercentage());
            Console.WriteLine("Price after offer:" + finalPrice);
        }

        public IOfferStrategy GetStrategy(int monthNo)
        {
            if (monthNo < 6)
            {
                return strategyContext[nameof(NoDiscountStrategy)];
            }
            else
            {
                return strategyContext[nameof(QuarterDiscountStrategy)];
            }
        }
    }


}