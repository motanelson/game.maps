using System;
using System.Threading;
using System.IO;
using System.Text;

public class Games{   
    static int score=0;
    static int fire=0;
    static int live=0;
    static int lives=3;
    static int x=0;
    static int y=0;
    static int z=0;
    static int w=0;
    static int h=0;
    static bool ends=false;
    static int camera=0;
    static int enemy=0;
    static int enemycount=3;
    static bool appends=false;
    static int tsleep=100;
    static string files ="log.txt";

    static void debugs(String c){
       if(!appends){
           Console.WriteLine(files);
           File.WriteAllText(files, c + Environment.NewLine, Encoding.UTF8);
        }else{
           File.AppendAllText(files, c + Environment.NewLine, Encoding.UTF8);
        }
       appends=true;
       Thread.Sleep(100);
    }
    static void checkgameover(){
        //put you code here
        debugs("checkgameover\n\n");
    
    
    }
    static void refreshscreen(){
        //put you code here
        debugs("refreshscreen");
    
    
    
    }
    static void handlescore(){
        //put you code here
        debugs("handlescore");
    
    }
    static void changenetwork(){
        //put you code here
        debugs("changenetwork");
    
    
    }
    static void drawplayers(){
        //put you code here
        debugs("drawplayers");
    
    
    
    
    }
    static void handlekeymouse(){
        //put you code here
        debugs("drawplayers");
    
    
    
    }
    static void drawenemys(){
        //put you code here
        debugs("drawenemys");
    
    }
    static void handlenemy(){
        //put you code here
        debugs("handlenemy");
    
    }
    static void drawmain(){
        //put you code here
        debugs("drawmain");
    }
    
    static void mainloop(){
        //put you code here
        debugs("mainloop");
        while(true){
            drawmain();
            handlenemy();
            drawenemys();
            handlekeymouse();
            drawplayers();
            changenetwork();
            handlescore();
            refreshscreen();
            checkgameover();
            if (ends)break;
        }
        
    }
    
    static void setuploop(){
        //put you code here
        debugs("setuploop");
        while(true){
           mainloop();
           if (ends)break;
        }
        
        
    }
    static void Main(String[] arg){
        //put you code here
        debugs("main");
        setuploop();
    
        
    }
}
