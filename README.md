# Prog_122_L10_DataClass

## Subject
What are data classess ( or records )?

A data class is a way of grouping a set of seperate fields ( properties or variables ) together by an Abstract name ( the class name ). 

[Refactoring Guru - What are data classes?](https://refactoring.guru/smells/data-class#:~:text=A%20data%20class%20refers%20to,the%20data%20that%20they%20own.)

## How to make a class

1. Right click on file in `Solution Explorer`
2. Hover over `Add`
3. Select `Class`
4. Give a name to your `Class`  
	* Class name **MUST** start with **UPPER CASE**
	* Class name is **Singular**

Ex.
```    
public class Album
    {

        string title;
        string artistName;
        int year;
        string albumCoverLocation;



    }

```

## How to use the class 

### Make an instance

To create a new ***Instance***  
**Declare Type - name - = - new keyword Type()**  
Ex. `Album albumName = new Album();`

### How to assign a value

`albumName.Field`

Ex. `albumName.title = "album title"`

### How to get the value

`rtbDisplay.Text = albumName.title`

```csharp
        Album juansChoice = new Album();
        juansChoice.title = "Thriller";
        juansChoice.artistName = "Michael Jackson";

        Album kirasChoice = new Album();
        kirasChoice.title = "Bad";
        kirasChoice.artistName="Michael Jackson";
        kirasChoice.year = 1987;

        // Object name.fieldName
    rtbDisplay.Text = kirasChoice.title;
```


## Table Example

Table for Albums ( Music )  
Fields ( Artist Name, Album Name, Year Released, Number of Songs )

| Artist Name    | Album Name               | Year Released | Number of Songs |
| -------------- | ------------------------ | ------------- | --------------- |
| John Doe       | Magic of the Night       | 1992          | 10              |
| The Skyliners  | Echoes from Beyond       | 2003          | 12              |
| Luna Wave      | Ocean's Whisper          | 2010          | 9               |
| Diamond Lights | Flash of Brilliance      | 2015          | 11              |
| Solar Flares   | Ecliptic Journeys        | 2000          | 14              |
| Anna Belle     | Moonlit Serenade         | 2020          | 8               |
| The Quivers    | Sounds of the Suburb     | 1985          | 10              |
| Velvet Stone   | Heartfelt Reverberations | 1999          | 13              |
| Whisper Twins  | Silent Echoes            | 2005          | 10              |
| Neon Pulse     | Vibrant Frequencies      | 2018          | 9               |

### In Class Question - What makes an album?
* A List of songs
* Artwork
* Title
* Artist Name
* Year Released

### In Class Example
* Benel - Elton John
* David - The Garden
* Hafsa - Baby Shark
* Juan - Michael Jackson
* Kira - Teena Marie
* Will - BTS

---
# In Class Notes - Data Classes

## What is a data class

### Headings ( 1 to 6 Hash Tags )

Single astrix next to word makes it italics  
*Italic*

Double astrix make a word bold  
**Bold**

Triple astrix makes word italic and bold  
***Italic Bold***

You can use organized numbers for lists  
Do double space enter after a line to go straight to new line
Two CODE syntax  
` <--- tilde in upper left corner`  

`Will have a generic code syntax`

3 tilde will do code specific syntax
```csharp
public static void main() {

}
```