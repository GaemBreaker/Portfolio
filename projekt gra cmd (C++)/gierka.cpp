#include <conio.h>
#include <iostream>
#include <windows.h>

using namespace std;

int lvl, hp, arm, stm,  dmg, eHP, eARM, eSTM, eDMG, baseHP, baseARM, baseDMG, fullHP, gold, myEXP, maxEXP, perk, baseSTM, hpUP, dmgUP, stmUP, armUP, knife, dagger,
longKnife, sword, bastardSword, longSword, greatSword, leather, reinforcedLeather, plastic, wooden, steel, metal, carrot, apple,
sandwich, cake, bacon, steak, veganMeal, fullMeal, random, random1, random2, i, option;


// Mechaniki, statystyki i inne rzeczy
void Character();
void Upgrades();
void Weapons();
void Armor();
void Food();
void Death();
void Combat();

// UI/Menus
void Menu();
void ExpMenu();
void WeaponShop();
void ArmorShop();
void FoodShop();
void Arena();

// ENEMIES
void Hobo();
void Gladiator();
void Spartan();
void Psycho();
void Assassin();
void Berserker();
void ArenaKing();



int main() {
    Character();
    Menu();
}

void Character() {

    lvl = 0;
    myEXP = 0;
    maxEXP = 100;
    perk = 0;
    baseHP = 100;
    hp = baseHP;
    fullHP = baseHP;
    baseARM = 50;
    arm = baseARM;
    baseDMG = 10;
    dmg = baseDMG;
    baseSTM = 80;
    stm = baseSTM;
    gold = 10;

    while (myEXP > 0){
        
        if (myEXP >= maxEXP) {
            lvl = lvl + 1;
            gold = gold + maxEXP;
            perk = perk + 1;

            cout << "Level Up! Gained: +100 base HP, +50 base Armor, +1 Perk point, +" << maxEXP << " gold.\n";
            cout << "Current LVL: " << lvl << ". Perk point available: " << perk << ".\n";

            myEXP = 0;
            maxEXP = maxEXP + (maxEXP/2);

        }

    }
    
}

void Menu() {

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(154);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 66 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 59 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 64 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 59 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 147 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 148 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(154);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 118 );
    cout << "What do you want to do?" << endl;
    cout.width( 116 );
    cout << "1. Open Upgrade Menu." << endl;
    cout.width( 127 );
    cout << "2. Go to Weapons Shop." << endl;
    cout.width( 115 );
    cout << "3. Go to Armor Shop." << endl;
    cout.width( 118 );
    cout << "4. Go to the Food Shop." << endl;
    cout.width( 114 );
    cout << "5. Go to the Arena." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;

    for (i=1;i<100;i++){

        cin >> option;

        if (option == 0){
            cout << "Wanted to be smart? Now you've sealed your fate.\n";
            i = 100;
            system("pause");
            system("cls");
            Death();
        }
        if (option == 1){
            i = 100;
            system("cls");
            ExpMenu();
        }
        if (option == 2){
            i = 100;
            system("cls");
            WeaponShop();
        }
        if (option == 3){
            i = 100;
            system("cls");
            ArmorShop();
        }
        if (option == 4){
            i = 100;
            system("cls");
            FoodShop();
        }
        if (option == 5){
            i = 100;
            system("cls");
            Arena();
        }
        if (option > 5){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option < 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }

}

void ExpMenu() {
    
    Upgrades();

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 93 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 91 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 206 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 207 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 118 );
    cout << "What do you want to do?" << endl;
    cout.width( 122 );
    cout << "(All upgrades cost 1 Perk Point)";
    cout.width( 203 );
    cout << "1. Upgrade base HP." << endl;
    cout.width( 117 );
    cout << "2. Upgrade base Armor." << endl;
    cout.width( 118 );
    cout << "3. Upgrade base Damage." << endl;
    cout.width( 119 );
    cout << "4. Upgrade base Stamina." << endl;
    cout.width( 106 );
    cout << "5. Go back." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;
    
    for (i=1;i<100;i++){

        cin >> option;

        if (option == 1){
            if (perk <= 0){
                cout << "You don't have enough Perk Points.\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
            else if (perk > 0){
                perk = perk - 1;
                hp = hpUP;
                baseHP = hpUP;
                cout << "Base HP +100! Base HP upgraded!\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
        }
        if (option == 2){
            if (perk <= 0){
                cout << "You don't have enough Perk Points.\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
            else if (perk > 0){
                perk = perk - 1;
                arm = armUP;
                baseARM = armUP;
                cout << "Base Armor +50! Base Armor upgraded!\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
        }
        if (option == 3){
            if (perk <= 0){
                cout << "You don't have enough Perk Points.\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
            else if (perk > 0){
                perk = perk - 1;
                dmg = dmgUP;
                baseDMG = dmgUP;
                cout << "Base Damage +30! Base Damage upgraded!\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
        }
        if (option == 4){
            if (perk <= 0){
                cout << "You don't have enough Perk Points.\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
            else if (perk > 0){
                perk = perk - 1;
                stm = stmUP;
                baseSTM = stmUP;
                cout << "Base Stamina +80! Base Stamina upgraded!\n";
                system("pause");
                system("cls");
                ExpMenu();
            }
        }
        if (option == 5){
            system("cls");
            Menu();
        }
        if (option > 5){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option <= 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }
}

void Upgrades() {

    hpUP = baseHP + 100; // Health points + 100.
    dmgUP = baseDMG + 30; // Damage + 30.
    stmUP = baseSTM + 80; // Stamina + 80.
    armUP = baseARM + 50; // Armor + 50.
}


// ENEMIES

    void Hobo(){

        eHP = 100;
        eARM = 50;
        eSTM = 80;
        eDMG = 10;
    }

    void Gladiator(){

        eHP = 200;
        eARM = 100;
        eSTM = 150;
        eDMG = 50;
    }

    void Spartan(){

        eHP = 500;
        eARM = 150;
        eSTM = 300;
        eDMG = 100;
    }

    void Psycho(){

        eHP = 500;
        eARM = 500;
        eSTM = 500;
        eDMG = 500;
    }

    void Assassin(){

        eHP = 750;
        eARM = 300;
        eSTM = 500;
        eDMG = 75;
    }

    void Berserker(){

        eHP = 750;
        eARM = 100;
        eSTM = 500;
        eDMG = 150;
    }

    void ArenaKing(){

        eHP = 1500;
        eARM = 1000;
        eSTM = 1000;
        eDMG = 300;
    }

void WeaponShop() {

    Weapons();

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 93 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 91 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 206 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 207 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 118 );
    cout << "What do you want to do?" << endl;
    cout.width( 119 );
    cout << "1. Buy: Knife. (50 gold)" << endl;
    cout.width( 121 );
    cout << "2. Buy: Dagger. (100 gold)" << endl;
    cout.width( 125 );
    cout << "3. Buy: Long Knife. (150 gold)" << endl;
    cout.width( 120 );
    cout << "4. Buy: Sword. (300 gold)" << endl;
    cout.width( 128 );
    cout << "5. Buy: Bastard Sword. (500 gold)" << endl;
    cout.width( 126 );
    cout << "6. Buy: Long Sword. (1000 gold)" << endl;
    cout.width( 127 );
    cout << "7. Buy: Great Sword. (1500 gold)" << endl;
    cout.width( 106 );
    cout << "8. Go back." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;
    
    for (i=1;i<100;i++){

        cin >> option;

        if (option == 1){
            if (gold < 50){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 50){
                gold = gold - 50;
                dmg = baseDMG;
                dmg = knife;
                cout << "You've bought a Knife! Base Damage +10!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 2){
            if (gold < 100){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 100){
                gold = gold - 100;
                dmg = baseDMG;
                dmg = dagger;
                cout << "You've bought a Dagger! Base Damage +25!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 3){
            if (gold < 150){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 150){
                gold = gold - 150;
                dmg = baseDMG;
                dmg = longKnife;
                cout << "You've bought a Long Knife! Base Damage +50!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 4){
            if (gold < 300){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 300){
                gold = gold - 300;
                dmg = baseDMG;
                dmg = sword;
                cout << "You've bought a Sword! Base Damage +100!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 5){
            if (gold < 500){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 500){
                gold = gold - 500;
                dmg = baseDMG;
                dmg = bastardSword;
                cout << "You've bought a Bastard Sword! Base Damage +200!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 6){
            if (gold < 1000){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 1000){
                gold = gold - 1000;
                dmg = baseDMG;
                dmg = longSword;
                cout << "You've bought a Long Sword! Base Damage +500!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 7){
            if (gold < 1500){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
            else if (gold >= 1500){
                gold = gold - 1500;
                dmg = baseDMG;
                dmg = greatSword;
                cout << "You've bought a Great Sword! Base Damage +1000!\n";
                system("pause");
                system("cls");
                WeaponShop();
            }
        }
        if (option == 8){
            system("cls");
            Menu();
        }
        if (option > 8){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option <= 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }
}

void Weapons() {

    knife = baseDMG + 10; // 10 dmg + 10 dmg = 20 dmg
    dagger = baseDMG + 25; // 10 dmg + 25 dmg = 35 dmg
    longKnife = baseDMG + 50; // 10 dmg + 50 dmg = 60 dmg
    sword = baseDMG + 100; // 10 dmg + 100 dmg = 110 dmg
    bastardSword = baseDMG + 200; // 10 dmg + 200 dmg = 210 dmg
    longSword = baseDMG + 500; // 10 dmg + 500 dmg = 510 dmg
    greatSword = baseDMG + 1000; // 10 dmg + 1000 dmg = 1010 dmg

}

void ArmorShop() {

    Armor();

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 93 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 91 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 206 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 207 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 118 );
    cout << "What do you want to do?" << endl;
    cout.width( 127 );
    cout << "1. Buy: Leather Armor. (50 gold)" << endl;
    cout.width( 139 );
    cout << "2. Buy: Reinforced Leather Armor. (100 gold)" << endl;
    cout.width( 128 );
    cout << "3. Buy: Plastic Armor. (150 gold)" << endl;
    cout.width( 127 );
    cout << "4. Buy: Wooden Armor. (300 gold)" << endl;
    cout.width( 126 );
    cout << "5. Buy: Steel Armor. (500 gold)" << endl;
    cout.width( 127 );
    cout << "6. Buy: Metal Armor. (1000 gold)" << endl;
    cout.width( 106 );
    cout << "7. Go back." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;

    for (i=1;i<100;i++){

        cin >> option;

        if (option == 1){
            if (gold < 50){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 50){
                gold = gold - 50;
                arm = baseARM;
                arm = leather;
                cout << "You've bought Leather Armor! Base Armor +10!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 2){
            if (gold < 100){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 100){
                gold = gold - 100;
                arm = baseARM;
                arm = reinforcedLeather;
                cout << "You've bought Reinforced Leather Armor! Base Armor +25!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 3){
            if (gold < 150){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 150){
                gold = gold - 150;
                arm = baseARM;
                arm = plastic;
                cout << "You've bought Plastic Armor! Base Armor +50!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 4){
            if (gold < 300){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 300){
                gold = gold - 300;
                arm = baseARM;
                arm = wooden;
                cout << "You've bought Wooden Armor! Base Armor +100!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 5){
            if (gold < 500){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 500){
                gold = gold - 500;
                arm = baseARM;
                arm = steel;
                cout << "You've bought Steel Armor! Base Armor +200!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 6){
            if (gold < 1000){
                cout << "You don't have enough gold.\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
            else if (gold >= 1000){
                gold = gold - 1000;
                arm = baseARM;
                arm = metal;
                cout << "You've bought Metal Armor! Base Armor +500!\n";
                system("pause");
                system("cls");
                ArmorShop();
            }
        }
        if (option == 7){
            system("cls");
            Menu();
        }
        if (option > 7){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option <= 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }
}

void Armor() {

    leather = baseARM + 10; // 50 arm + 10 arm = 60 arm
    reinforcedLeather = baseARM + 25; // 50 arm + 25 arm = 75 arm
    plastic = baseARM + 50; // 50 arm + 50 arm = 100 arm
    wooden = baseARM + 100; // 50 arm + 100 arm = 150 arm
    steel = baseARM + 200; // 50 arm + 200 arm = 250 arm
    metal = baseARM + 500; // 50 arm + 500 arm = 550 arm

}

void FoodShop() {

    Food();

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 93 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 91 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 206 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 207 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 118 );
    cout << "What do you want to do?" << endl;
    cout.width( 119 );
    cout << "1. Buy: Carrot. (5 gold)" << endl;
    cout.width( 119 );
    cout << "2. Buy: Apple. (10 gold)" << endl;
    cout.width( 122 );
    cout << "3. Buy: Sandwich. (15 gold)" << endl;
    cout.width( 118 );
    cout << "4. Buy: Cake. (20 gold)" << endl;
    cout.width( 119 );
    cout << "5. Buy: Bacon. (50 gold)" << endl;
    cout.width( 120 );
    cout << "6. Buy: Steak. (100 gold)" << endl;
    cout.width( 125 );
    cout << "7. Buy: Vegan Meal. (200 gold)" << endl;
    cout.width( 125 );
    cout << "8. Buy: Full Meal. (300 gold)." << endl;
    cout.width( 106 );
    cout << "9. Go back." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;

    for (i=1;i<100;i++){

        cin >> option;

        if (option == 1){
            if (gold < 5){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 5){
                gold = gold - 5;
                hp = carrot;
                cout << "You've bought a Carrot! Regenerated +5 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 2){
            if (gold < 10){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 10){
                gold = gold - 10;
                hp = apple;
                cout << "You've bought an Apple! Regenerated +10 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 3){
            if (gold < 15){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 15){
                gold = gold - 15;
                hp = sandwich;
                cout << "You've bought a Sandwich! Regenerated +15 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 4){
            if (gold < 20){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 20){
                gold = gold - 20;
                hp = cake;
                cout << "You've bought a Cake! Regenerated +20 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 5){
            if (gold < 50){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 50){
                gold = gold - 50;
                hp = bacon;
                cout << "You've bought a Bacon! Regenerated +50 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 6){
            if (gold < 100){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 100){
                gold = gold - 100;
                hp = steak;
                cout << "You've bought a Steak! Regenerated +100 HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 7){
            if (gold < 200){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 200){
                gold = gold - 200;
                hp = veganMeal;
                cout << "You've bought a Vegan Meal! Regenerated half of your HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 8){
            if (gold < 300){
                cout << "You don't have enough gold.";
                system("pause");
                system("cls");
                FoodShop();
            }
            else if (gold >= 300){
                gold = gold - 300;
                hp = fullMeal;
                cout << "You've bought a Full Meal! Regenerated all of your HP!\n";
                if (hp > fullHP){
                    hp = fullHP;
                    cout << " Your HP is full!\n";
                }
                system("pause");
                system("cls");
                FoodShop();
            }
        }
        if (option == 9){
            system("cls");
            Menu();
        }
        if (option > 9){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option <= 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }

}

void Food() {

    carrot = hp + 5; // +5 hp regen
    apple = hp + 10; // +10 hp regen
    sandwich = hp + 15; // +15 hp regen
    cake = hp + 20; // +20 hp regen
    bacon = hp + 50; // +50 hp regen
    steak = hp + 100; // +100 hp regen
    veganMeal = hp + (fullHP/2); // +50% hp regen
    fullMeal = hp + fullHP; // +100% hp regen

}

void Death(){
    system("cls");
    cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl
    << endl << endl << endl << endl << endl << endl << endl;
    cout.fill(' ');
    cout.width( 111 );
    cout << "YOU DIED\n";
    system("Color 04");
    cout << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl
    << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;
    system("pause");
    exit;
}

void Arena() {

    system("cls");
    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl;

    cout.fill(' ');
    cout.width( 12 );
    cout << "Gold: " << "\033[38;5;202m" << gold <<"\033[0m" << " ||";
    cout.width( 93 );
    cout << "Level: " << "\033[38;5;220m" << lvl << "\033[0m";
    cout.width( 91 );
    cout << "|| HP: " << "\033[38;5;196m" << hp << "\033[0m" << "/" << "\033[38;5;196m" << baseHP << "\033[0m" << "\n";
    cout.width( 13 );
    cout << "Perk Points: " << "\033[38;5;196m" << perk << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Exp: " << "\033[38;5;220m" << maxEXP << "\033[0m" << " ||";
    cout.width( 91 );
    cout << "|| Armor: " << "\033[38;5;8m" << arm << "\033[0m" << "\n";
    cout.width( 206 );
    cout << "|| Damage: " << "\033[38;5;196m" << dmg << "\033[0m" << "\n";
    cout.width( 207 );
    cout << "|| Stamina: " << "\033[38;5;12m" << stm << "\033[0m" << "\n";

    cout <<"\033[48;5;88m" << "-";
    cout.width(209);
    cout.fill('-');
    cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;

    cout.fill(' ');
    cout.width( 120 );
    cout << "Who do you want to fight?" << endl;
    cout.width( 103 );
    cout << "1. Hobo." << endl;
    cout.width( 108 );
    cout << "2. Gladiator." << endl;
    cout.width( 106 );
    cout << "3. Spartan." << endl;
    cout.width( 105 );
    cout << "4. Psycho." << endl;
    cout.width( 107 );
    cout << "5. Assassin." << endl;
    cout.width( 108 );
    cout << "6. Berserker." << endl;
    cout.width( 109 );
    cout << "7. Arena King." << endl;
    cout.width( 106 );
    cout << "8. Go back." << endl;
    cout.width( 121 );
    cout << "(type the number to proceed)" << endl;

    for (i=1;i<100;i++){

        cin >> option;

        if (option == 1){
            Hobo();

            Combat();
        }
        if (option == 2){
            Gladiator();

            Combat();
        }
        if (option == 3){
            Spartan();

            Combat();
        }
        if (option == 4){
            Psycho();

            Combat();
        }
        if (option == 5){
            Assassin();

            Combat();
        }
        if (option == 6){
            Berserker();

            Combat();
        }
        if (option == 7){
            ArenaKing();

            Combat();
        }
        if (option == 8){
            system("cls");
            Menu();
        }
        if (option > 8){
            cout << "Nice try but no. Choose correct option.\n";
        }
        if (option <= 0){
            cout << "Nice try but no. Choose correct option.\n";
        }
    }

}

void Combat(){

    int random, random1, random2, i, option;

    for (i=1;i<100;i++){

        system("cls");
        cout <<"\033[48;5;88m" << "-";
        cout.width(209);
        cout.fill('-');
        cout << "-" <<"\033[0m" << endl;

        cout.fill(' ');
        cout.width( 3 );
        cout << "You" << "\033[38;5;15m" << "\033[0m";
        cout.width( 190 );
        cout << "Enemy" << "\033[38;5;9m" << "\033[0m" << endl;
        cout.width( 4 );
        cout << "HP: " << "\033[38;5;196m" << hp << "\033[0m";
        cout.width( 185 );
        cout << "HP: " << "\033[38;5;196m" << eHP << "\033[0m" << endl;
        cout.width( 7 );
        cout << "Armor: " << "\033[38;5;8m" << arm << "\033[0m";
        cout.width( 186 );
        cout << "Armor: " << "\033[38;5;8m" << eARM << "\033[0m" << endl;
        cout.width( 8 );
        cout << "Damage: " << "\033[38;5;124m" << dmg << "\033[0m";
        cout.width( 186 );
        cout << "Damage: " << "\033[38;5;124m" << eDMG << "\033[0m" << endl;

        cout <<"\033[48;5;88m" << "-";
        cout.width(209);
        cout.fill('-');
        cout << "-" <<"\033[0m" << endl << endl << endl << endl << endl << endl << endl << endl << endl << endl;


        random = rand() % 11;
        random1 = rand() % 21;
        random2 = rand() % 11;

        cout << "1. Attack\n";
        cout << "2. Defense\n";
        
        cin >> option; // Wybór opcji: atakować, czy bronić się.

        if (option == 1){ // Jeśli wybrano atak to:
            if (random <=5){ // Zwykły atak gracza.
                if(eARM>0){ // Jeśli przeciwnik ma pancerz, gracz uderza w pancerz przeciwnika.
                    eARM = eARM - dmg;
                    cout << "Attacked for " << dmg << " damage.\n";
                    if (eARM<=0){
                        eARM = 0;
                    }
                }
                else{ // Jeśli przeciwnik nie ma pancerza, gracz uderza przeciwnika.
                    eHP = eHP - dmg;
                    cout << "Attacked for " << dmg << " damage.\n";
                    if (eHP<=0){
                        eHP = 0;
                    }
                }
            }
            else if (random > 5; random < 9){ // Nietrafiony atak gracza.
                cout << "Attack missed.\n";
            }
            else if (random >= 9){ // Atak krytyczny gracza.
                if(eARM>0){ // Jeśli przeciwnik ma pancerz, gracz uderza atakiem krytycznym w pancerz przeciwnika.
                    eARM = eARM - (dmg*2);
                    cout << "Critical attack! Attacked for " << dmg*2 << " damage.\n";
                    if (eARM<=0){
                        eARM = 0;
                    }
                }
                else{ // Jeśli przeciwnik nie ma pancerza, gracz uderza atakiem krytycznym w przeciwnika.
                    eHP = eHP - (dmg*2);
                    cout << "Critical attack! Attacked for " << dmg*2 << " damage.\n";
                }
            }
        }
        else if (option == 2){ // Jeśli wybrano obronę.
            cout << "Countering next attack.\n";
        }

        if (eHP <=0){ // Jeśli przeciwnik ma 0 hp.

            cout << "Enemy slained.\n";
            if (random1 > 10){ // Bonus gold and exp.
                gold = gold + 200;
                myEXP = myEXP + 20;
                cout << "You received +200 gold & +20 exp.\n";
                system("pause");
                Arena();
            }
            else if (random1 < 10){ // Normal gold and exp.
                gold = gold + 100;
                myEXP = myEXP + 10;
                cout << "You received +100 gold & +10 exp.\n";
                system("pause");
                Arena();
            }

        }

        system("pause");

        if (option == 1){
            if (random2 >= 6){ // Zwykły atak przeciwnika.
                if(arm>0){ // Jeśli gracz ma pancerz, przeciwnik uderza w pancerz gracza.
                    arm = arm - eDMG;
                    cout << "Enemy attacked for " << eDMG << " damage.\n";
                    if (arm<=0){
                        arm = 0;
                    }
                }
                else{ // Jeśli gracz nie ma pancerza, przeciwnik uderza w gracza.
                    hp = hp - eDMG;
                    cout << "Enemy attacked for " << eDMG << " damage.\n";
                    if (hp<=0){
                        hp = 0;
                    }
                }
            }
            else if (random2 > 2; random2 < 6){ // Nietrafiony atak przeciwnika.
                cout << "Enemy missed attack.\n";
            }
            else if (random2 <= 2){ // Atak krytyczny przeciwnika.
                if(arm>0){ // Jeśli gracz ma pancerz, przeciwnik uderza atakiem krytycznym w pancerz gracza.
                    arm = arm - (eDMG*2);
                    cout << "Critical attack! Enemy attacked for " << eDMG*2 << " damage.\n";
                    if (arm<=0){
                        arm = 0;
                    }
                }
                else{ // Jeśli gracz nie ma pancerza, przeciwnik uderza atakiem krytycznym w gracza.
                    hp = hp - (eDMG*2);
                    cout << "Critical attack! Enemy attacked for " << eDMG*2 << " damage.\n";
                    if (hp<=0){
                        hp = 0;
                    }
                }
            }
        }
        else if (option == 2){
            cout << "Countered " << eDMG << " damage from the enemy.\n";
        }

        system("pause");

        if (hp <= 0){
            i = 101;
            Death();
        }


    }
    
}