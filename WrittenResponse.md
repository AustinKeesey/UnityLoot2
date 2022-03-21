# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Create an entertaining random generator that displays different loot for the user to admire. 


### 3a ii.

My video demonstrates how my program can prompt the user to say how many combinations of loot they would like and the requested amount is then displayed
 The video shows that my program generates random sprites based on user input.

### 3a iii.


My program receives a numeric input ranging from 1 to 3 from the user and then outputs a list containing that many loot combinations

The program input is the user pressing a button and the outputs are sprites that are loaded in.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Weapon"))
       {
           MeleeWeapons.Add(obj);
       }
```
### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (GameObject weapon in MeleeWeapons)
        {
            weapon.SetActive(false);
        }
```


### 3b iii.

MeleeWeapons in the name of the list being used.

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all of the possible melee weapons that are  to be generated

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**

Without a list, it would be difficult but not impossible for there to be a selection of weapons since there would be no random index. If I wanted to add more possibilities it would make the process very redundant and not efficient. In order to manage complexity, this list allows the program to efficiently generate a random weapon without the need of numerous if / else if statements for each possible random number that could be generated.

Without a list, it would be more difficult to add weapons because I would have to make a variable for every weapon that I want ot add. I also would not be able to write a loop that broadens my code to a single line. The list allows me to add weapons without changing or adding any new code.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public void SetWeapon(GameObject newSprite)
    {
        if (newSprite == null )
        {
            throw new System.Exception("QUACK");
        }

        
        foreach (GameObject weapon in MeleeWeapons)
        {
            weapon.SetActive(false);
        }
        System.Random generator = new System.Random();
        int index = generator.Next(0, MeleeWeapons.Count);
        MeleeWeapons[index].SetActive(true);
        // newSprite.SetActive(true);

        foreach (GameObject weapon in ProjectileWeapons)
        {
            weapon.SetActive(false);
        }

        int index1 = generator.Next(0, ProjectileWeapons.Count);
        ProjectileWeapons[index1].SetActive(true);
    }
```
          
### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.
```csharp
 public void OnClickButton (GameObject sprite)
    {
        SetWeapon(sprite);
    }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a game object, all weapon sprites are turned off and a new sprite is passed in. A random weapon gets generated from MeleeWeapons and that weapon is to be set active.
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Checks if there is a sprite at all, if not then an exception is thrown
2. If there is a sprite, then for each weapon GameObject in MeleeWeapons, the rest of the weapons get set to inactive.
3. Create a random sprite generator 
4. Generate a random Projectile sprite
5. Generate a random Melee sprite 
6. Show the sprites on the unity avatar

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 
SetWeapon(null);

**TODO: Complete this section**

Second call:
SetWeapon(WitherhoardObject;

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

I am testing if the user has inputted is null. This will cause the body of the if statement to execute.
 
**TODO: Complete this section**

Condition(s) tested by the second call:

I am testing is the prompt the user has inputted is not null. This will skip the the body of the if statement. 

**TODO: Complete this section**

### 3d iii.

Result of the first call:

The result of the first call is that sprites are null and that exception gets thrown.



Result of the second call:
The result of calling this would randomly select a sprite.

