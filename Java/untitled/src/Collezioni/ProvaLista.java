package Collezioni;

import java.util.ArrayList;
import java.util.List;

public class ProvaLista {
    public static void main(String[] args){
        List<String> note = new ArrayList<>();//new LinkedList;
        note.size();
        note.add("fa");
        note.add("fa");
        note.get(0);
        //note remove(0);

        for (int i=0; i<note.size();i++) {
            System.out.println(note.get(i));
        }
        for (String nota : note){
            System.out.println(nota);
        }
        //note foreach(n -> System.out.println(n));

    }
}
