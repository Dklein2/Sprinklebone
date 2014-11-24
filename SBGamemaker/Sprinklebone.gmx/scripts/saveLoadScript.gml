if (argument0 == "save" )
{


ini_open(selectedProfile+"_save1.ini");
    ini_write_string ("general","isSave","Save"+"1"+" | BlahBlah");
    //ini_write_string("Position","room",argument1); //This saves the room number that the player is in.
    ini_write_real("Position","posX",playerCharacter.x); //This saves the players X Position.
    ini_write_real("Position","posY",playerCharacter.y); //This saves the players Y Position.

ini_close(); //Closes the ini file
}




if (argument0 == "load" )
{
ini_open(selectedProfile+"_save1.ini");
    //ini_write_string("Position","room",argument1); //This saves the room number that the player is in.
    global.playerInitialX = ini_read_real("Position","posX",0); //This saves the players X Position.
    global.playerInitialY = ini_read_real("Position","posY",0); //This saves the players Y Position.
ini_close();
}

if (argument0 == "new")
{

    //ini_write_string("Position","room",argument1); //This saves the room number that the player is in.
    global.playerInitialX = 50;
    global.playerInitialY = 50;

}
