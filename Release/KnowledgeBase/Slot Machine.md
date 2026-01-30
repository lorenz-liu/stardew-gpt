# Slot Machine

[![Slot Machine.gif](/mediawiki/images/b/ba/Slot_Machine.gif)](/File:Slot_Machine.gif)

[![Slot Machine Rewards.png](/mediawiki/images/thumb/f/fd/Slot_Machine_Rewards.png/340px-Slot_Machine_Rewards.png)](/File:Slot_Machine_Rewards.png)

**Slot Machines** are a mini-game found in the [Casino](/Casino "Casino").

The player can bet either 10 or 100 Qi coins when using a slot machine. If the results match one of the winning lines, the player receives a multiple of their bet. If there is no match the player loses their bet.

Daily [Luck](/Luck "Luck") and Luck buffs (from [food](/Cooking "Cooking") items, [Ginger Ale](/Ginger_Ale "Ginger Ale"), [Lucky Rings](/Lucky_Ring "Lucky Ring"), etc.) can increase the chance of winning and the expected return when gambling. Otherwise, rolls are randomly determined.

## Winning lines

There are 10 possible winning lines, each one giving different multipliers.

| Line | Chance[[1]](#cite_note-slots-1) | Multiplier |
| --- | --- | --- |
| [Cherry.png](/File:Cherry.png) | 20% | 2 |
| [Cherry.png](/File:Cherry.png)[Cherry.png](/File:Cherry.png) | 10% | 3 |
| [Parsnip.png](/File:Parsnip.png)[Parsnip.png](/File:Parsnip.png)[Parsnip.png](/File:Parsnip.png) | 8% | 5 |
| [Large Milk.png](/File:Large_Milk.png)[Large Milk.png](/File:Large_Milk.png)[Large Milk.png](/File:Large_Milk.png) | 1% | 30 |
| [Rainbow Trout.png](/File:Rainbow_Trout.png)[Rainbow Trout.png](/File:Rainbow_Trout.png)[Rainbow Trout.png](/File:Rainbow_Trout.png) | 0.3% | 80 |
| [Nautilus Shell.png](/File:Nautilus_Shell.png)[Nautilus Shell.png](/File:Nautilus_Shell.png)[Nautilus Shell.png](/File:Nautilus_Shell.png) | 0.2% | 120 |
| [Melon.png](/File:Melon.png)[Melon.png](/File:Melon.png)[Melon.png](/File:Melon.png) | 0.25% | 200 |
| [Cherry.png](/File:Cherry.png)[Cherry.png](/File:Cherry.png)[Cherry.png](/File:Cherry.png) | 0.09% | 500 |
| [Diamond.png](/File:Diamond.png)[Diamond.png](/File:Diamond.png)[Diamond.png](/File:Diamond.png) | 0.06% | 1000 |
| [Stardrop.png](/File:Stardrop.png)[Stardrop.png](/File:Stardrop.png)[Stardrop.png](/File:Stardrop.png) | 0.01% | 2500 |

This is adjusted multiplicatively by daily Luck, increasing by 20% at best or decreasing by 20% at worst with the [Special Charm](/Special_Charm "Special Charm") adding 5%. Food buffs add 8% for every point of Luck (*e.g.,* if daily Luck is max and luck from food is 3 then the chance to get 1 cherry is 20% \* (1 + 0.2 + 0.24) = 28.8%).

## Expected Value Calculation

To calculate the expected net gain or loss from playing the slot machine, we use the formula:

**Net Expected Gain/Loss = (B × Σ(Pi × Mi)) - B**

Where:

* *B* = Bet amount (in units)
* *Pi* = Probability of the i-th outcome
* *Mi* = Multiplier for the i-th outcome
* *Σ* = Sum over all possible outcomes (i=1 to n)

After accounting for the following:

**Net Expected Gain/Loss = B × ((0.2 × 2) + (0.1 × 3) + (0.08 × 5) + (0.01 × 30) + (0.003 × 80) + (0.002 × 120) + (0.0025 × 200) + (0.0009 × 500) + (0.0006 × 1000) + (0.0001 × 2500)) - B**

Which simplifies to:

**Net Expected Gain/Loss = B × 3.68 - B = B × (3.68 - 1)**

Then reducing to:

**Net Expected Gain/Loss = B × 2.68**

To simplify, if you spend data-sort-value="100">![QiCoin.png](/mediawiki/images/thumb/6/6c/QiCoin.png/24px-QiCoin.png)100 on a spin you can expect a net gain of data-sort-value="268">![QiCoin.png](/mediawiki/images/thumb/6/6c/QiCoin.png/24px-QiCoin.png)268 per spin!

## References

1. [↑](#cite_ref-slots_1-0) See `Slots::setSlotResults` in the game code.

## History

* [1.4](/Version_History#1.4 "Version History"): Recalculated the way random number generation is done, removing repeating pattern exploits. All [Casino](/Casino "Casino") games now slightly favor the player rather than the house.