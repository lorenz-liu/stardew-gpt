# Combat/Mechanics

:   *This article is about combat mechanics. For information about the combat [skill](/Skills "Skills"), see [Combat](/Combat "Combat").*

## Damage

In Stardew Valley, damage dealt to monsters is determined by a combination of weapon stats, rings, professions, and [Luck](/Luck "Luck").

### Formula overview

`FinalDamage = (BaseDamage × CritMultiplier (if crit)  
    + Attack (stat) × 3)  
    × FighterBonus (×1.1 if active)  
    × BruteBonus (×1.15 if active)  
    × DesperadoBonus (×2 if crit and active)  
    → Modified by enchantments  
    → Reduced by monster defense`

### Base damage roll

* A random value is rolled between the weapon’s `minDamage` and `maxDamage`.
* [Ruby forging](/Forge#Weapon_forging "Forge") increases a weapon's `minDamage` and `maxDamage` by 10% per Ruby (up to 3)[[1]](#cite_note-rubyenchantment-1). Three Ruby forges would increase `minDamage` and `maxDamage` by 30% total.
* [Ruby Rings](/Ruby_Ring "Ruby Ring") and [Iridium Bands](/Iridium_Band "Iridium Band") affect `minDamage` and `maxDamage` by 10% per ring. These effects are multiplicative with the [Ruby forging](/Forge#Weapon_forging "Forge") increase[[2]](#cite_note-ringcrit-2).
* This makes the effective `minDamage` and `maxDamage` formula `minDamage = weaponMinDamage × (100% + rubyForgeCount × 10%) × (100% + ringBonusPercent)`, where `ringBonusPercent` is the sum of all equipped ring effects which increase Attack by a percentage. If a player equipped two combined rings of [Iridium Band](/Iridium_Band "Iridium Band") and [Ruby Ring](/Ruby_Ring "Ruby Ring"), `ringBonusPercent` would be `10% (Ruby Ring) + 10% (Iridium Band) + 10% (Ruby Ring) + 10% (Iridium Band) = 40%`.

### Critical Hit Check

* If a crit occurs, the base damage is multiplied by critMultiplier, which is calculated as: `critMultiplier = (3 + CritPower / 50) × (1 + CriticalPowerMultiplier)`
* `CritPower` is the total of the [Crit. Power](/Crit._Power "Crit. Power") stat from [Weapons](/Weapons "Weapons") and [Jade forging](/Forge#Weapon_forging "Forge").
* `CriticalPowerMultiplier` is the effects of buffs: [Innate enchantments](/Forge#Enchantments "Forge") and [Jade Ring](/Jade_Ring "Jade Ring")

### Attack Stat Bonus

* The player’s Attack stat (from food, gear, and +Attack [Innate enchantments](/Forge#Enchantments "Forge")) adds: `+3 damage per Attack point`

### Profession Bonuses

* Fighter: +10% damage
* Brute: +15% damage
* These are applied multiplicatively and stack, so if both Fighter and Brute are active, the effective damage increase is `110% × 115% = 127%`.

### Desperado Profession

* If the hit is a critical strike and the player has the [Desperado](/Skills#Combat "Skills") profession, damage is doubled.

### Enchantments

If a weapon is [enchanted](/Forge#Combat_enchantments "Forge") with Bug Slayer or Crusader and the damaged monster type matches the enchantment effect, damage is increased by 50%.

### Monster defense

Monster defense is subtracted from the damage roll. Damage is always at least 1, even after defense reduction.

## Critical hit chance

### Calculation

Critical hit chance is computed in the following order:

**Calculate weapon crit chance**

In 1.5, the [Aquamarine forging](/Forge#Weapon_forging "Forge") increases weapon critical hit chance by 4.6%[[3]](#cite_note-aquamarineenchantment-3).
`CritChance = Base weapon crit. chance[4] + (4.6% × number of Aquamarine forges)`

If weapon type is [dagger](/Weapons#Dagger "Weapons"), `CritChance = (CritChance + 0.5%) × 1.12`[[5]](#cite_note-dagger-5)

**Apply [Aquamarine Ring](/Aquamarine_Ring "Aquamarine Ring") and [innate enchantments](/Forge#Innate_enchantments "Forge")**

Each [aquamarine ring](/Aquamarine_Ring "Aquamarine Ring") equipped gives a 10% bonus.[[2]](#cite_note-ringcrit-2)
If the weapon has a "+X Crit. Chance" [innate enchantment](/Forge#Innate_enchantments "Forge"), then each enchantment level adds a 2% bonus (up to 6% for a level 3 enchantment). (The tooltip displays "+1 Crit. Chance" for a level 1 enchantment.)
`CritChance = (CritChance × (1 + number of Aquamarine rings × 10% + Innate enchantment level × 2%)`

**Apply Blessing of Fangs bonus**

If the Blessing of Fangs buff from [Statue Of Blessings](/Statue_Of_Blessings "Statue Of Blessings") is active, Critical hit chance gets an additive increase of 10%.
`CritChance = CritChance + 10%`

**Apply Scout profession**

If the player has the Scout Profession, critical hit chance is increased by 50%.[[6]](#cite_note-scoutcode-6)
`CritChance = CritChance × 150%`

**Apply Luck**

Critical hit chance is increased based on the player's [Luck](/Luck "Luck")[[7]](#cite_note-luckcrit-7).
`CritChance = LuckLevel * CritChance / 40`

### Examples

**[Galaxy Sword](/Galaxy_Sword "Galaxy Sword") build**

* Aquamarine forging x3
* Aquamarine ring x2
* Blessing of Fangs
* Scout profession
* 2 Luck

Calculation:

1. Weapon crit chance: `2% + (4.6% × 3 (Aquamarine forging)) = 15.8%`
2. Rings & innate enchantment: `15.8% × (1 + 10% × 2 (Aquamarine rings)) = 15.8% × 120% = 19.0%`
3. Blessing of Fangs: `19% + 10% = 29%`
4. Scout profession: `29% × 150% = 43.4%`
5. Luck: `43.4% + 2 (Luck) × 43.4% / 40 = 43.4% + 2.2 = 45.6%`

## Critical hit damage

### Calculation

A critical strike does additional damage to an enemy. A special sound plays when hitting a critical strike, and the damage numbers that pop up show the greater damage amount. A critical strike effectively multiplies the damage roll by a calculated value called `CritMultiplier` in this article, calculated as follows: `CritMultiplier = (3 + Crit. Power (stat) / 50) × (1 + Crit. Power Bonus)`

The [Desperado](/Skills#Combat "Skills") Profession also affects the damage dealt by a Critical strike, doubling damage after bonus [Attack](/Attack "Attack") damage has been added. ([Attack](/Attack "Attack") stat is otherwise a "flat" bonus which is not increased by Critical strike bonuses.)

[Crit. Power](/Crit._Power "Crit. Power") (stat) can be found on:

* [Weapons](/Weapons "Weapons")
* [Jade enchantments](/Forge#Combat_enchantments "Forge"): +5 Crit. Power per enchantment

Crit. Power Bonus is increased by:

* [Jade Ring](/Jade_Ring "Jade Ring"): +10% per ring
* [Innate enchantments](/Forge#Innate_enchantments "Forge"): +50% per enchantment level. A Crit. Power Innate enchantment shows as +25 "Crit. Power" per level, so a "+75 Crit. Power" tooltip represents a level 3 enchantment and thus increases Crit. Power Bonus by 150%.

### Example

* A normal attack using the [Lava Katana](/Lava_Katana "Lava Katana") can do 55-64 damage. Assume an attack rolls 60 damage.
* A Lava Katana has 25 Crit. Power, so `CritMultiplier = 3 + 25 / 50 = 3.5`
* If the Lava Katana was forged with 3 Jades, Crit. Power would be increased by 15, for a total of 40 (though it shows up as +39 ingame due to rounding errors). This means the damage would instead be `CritMultiplier = 3 + (25 + 15) / 50 = 3 + 40 / 50 = 3.8`.
* With 2 Jade Rings and a +75 Crit. Power (level 3) innate enchantment, Crit. Power Bonus would equal `10% (Jade Ring) x 2 + 150% (Innate enchantment) = 170%`, making `CritMultiplier = 3.8 × (100% + 170%) = 10.26`.
* A base damage roll of 60 damage that was a critical strike with this setup would deal `60 × 10.26 = 615.6` damage.
* The [Desperado](/Skills#Combat "Skills") effectively doubles the damage again (after the Attack stat is applied), so the resulting damage would be `615.6 × 2 = 1231.2`.

## Player defense

### Damage variance

Monster damage varies by a random fluctuation between `7/8`ths and just below `9/8`ths of the [Monster](/Monsters "Monsters")'s base damage[[8]](#cite_note-farmerdamage-8). The formula can be expressed as follows: `minDamage <= actualDamage < maxDamage`, where `fluctuationDamage = int(monsterBaseDamage / 8)` and `minDamage = monsterBaseDamage - fluctuationDamage` and `maxDamage = monsterBaseDamage + fluctuationDamage`.

Example: A [Shadow Brute](/Shadow_Brute "Shadow Brute") has a base damage of 18, so `fluctationDamage = 18 / 8 = 2.25 => 2`, meaning the actual damage ranges between `16` and `19`, because `18 - 2 = 16` and `18 + 2 = 20`, but the upper bound is less than `20` (not less than or equal).

### Determining player defense

Applicable defense is the player's [Defense](/Defense "Defense") stat total from among [Boots](/Boots "Boots"), [Weapon](/Weapon "Weapon"), [Rings](/Rings "Rings"), [Food](/Food "Food") buffs plus 1 if the player has read [Jack Be Nimble, Jack Be Thick](/Jack_Be_Nimble,_Jack_Be_Thick "Jack Be Nimble, Jack Be Thick")[[8]](#cite_note-farmerdamage-8).
If defense is greater than or equal to half the actual damage being dealt, defense is reduced by up to 20% [[8]](#cite_note-farmerdamage-8). This causes a slight dampening of the defense stat in low-damage scenarios. If `defense >= damage / 2`, defense is reduced by either 0%, 10%, or 20% (randomly determined), using the following formula: `defenseReduction = int(defense × reductionPercent)`, `defense = defense - defenseReduction`.

Example: A [Duggy](/Duggy "Duggy") has a base damage of 6. If 6 damage would be dealt to a player with a [Defense](/Defense "Defense") of 5, half of 6 damage is 3. Since `5 (Defense) >= 3 (half damage)`, defense could be lowered by up to 20%. `5 (Defense) × 20% = 1`, so in this scenario a player's effective defense could be reduced by up to 1.

### Damage is applied

Incoming damage is reduced by the applicable defense, to a minimum of `1`[[8]](#cite_note-farmerdamage-8).

Example: 10 damage is dealt to a player with 6 defense. The player would take 4 damage, because `10 - 6 = 4`.

## References

1. [↑](#cite_ref-rubyenchantment_1-0) See `StardewValley::RubyEnchantment`.
2. ↑ [2.0](#cite_ref-ringcrit_2-0) [2.1](#cite_ref-ringcrit_2-1) See `StardewValley::Tools::MeleeWeapon.DoDamage` and `StardewValley::Objects::Ring`.
3. [↑](#cite_ref-aquamarineenchantment_3-0) See `StardewValley::AquamarineEnchantment`.
4. [↑](#cite_ref-weaponsxnb_4-0) See `weapons.xnb` file in the game data.
5. [↑](#cite_ref-dagger_5-0) See `StardewValley::Tools::MeleeWeapon.DoDamage`; the dagger weapon type is 1.
6. [↑](#cite_ref-scoutcode_6-0) See `StardewValley::GameLocation.damageMonster`.
7. [↑](#cite_ref-luckcrit_7-0) See `StardewValley::GameLocation.damageMonster`; the formula does not edit the crit chance but luck level is added in the if statement to check for a crit.
8. ↑ [8.0](#cite_ref-farmerdamage_8-0) [8.1](#cite_ref-farmerdamage_8-1) [8.2](#cite_ref-farmerdamage_8-2) [8.3](#cite_ref-farmerdamage_8-3) See `StardewValley::StardewValley::Farmer.takeDamage()`.