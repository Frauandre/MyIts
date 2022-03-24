``` bash
## |||| HISTORY COMANDI DEL 25.02 in versione ripulita e commentata, comprendente i comandi delle bash utente e root (fornite dal prof in file separati) in modo accorpato al fine di ricostruire il più fedelmente possibile quanto avvenuto in classe |||| 

## ---- COMANDI DI NAVIGAZIONE & UTILITA VARIE ---- 

ls  # list del contenuto di una directory
ls -alh  # list con opzioni: -a (all, mostra anche file nascosti), -l (list con formato lungo, più dettagliato), -h (formato human readable)
ls -l --all --human-readable # stessa cosa sopra ma con le opzioni scritte in modo esteso
clear #pulisce schermata del terminale
ls -lah /home   # listing di una directory specifica, in questo caso /home 
man ls   # man + comando richiama il manuale (attraverso il programma bash man) per quel comando
ls --help  # vengono stampate sul terminale info utili sul comando, ma è meglio usare man
ls /home/its-usr/  # la directory home contiene directory per ogni utente del sistema. In questo caso si naviga alla directory di tale utente con nome its-usr
history  # stampa a schermo tutta l'history (cronologia) dei comandi dati dall'utente loggato. Il numero di comandi dipende dalla configurazione, in generale di default sono tanti (circa 500?)
cd ~  # cd permette di muoversi all'interno di una determinata directory. ~ si chiama tilde ed è un alias per indicare la directory home dell'utente loggato. Nota: su windows si fa con Alt + 126 (da tastierino numerico)
# NOTA: in unix, ogni directory ha al suo interno due 'file' nascosti, "." e "..". 
cd . # "." identifica la directory stessa
cd .. # ".." è un riferimento alla directory superiore/madre/padre/comedirsivoglia.
top   # comando che visualizza a schermo i vari processi di sistema con relativo impiego di cpu, ecc. 
touch miofile   # crea un file di nome 'miofile'. Nota: il comando non nasce per questo fine, ma il mondo ormai lo accetta come pratica diffusa. Il file verrà creato nella stessa directory in cui si è sulla bash. Per sapere in che directory si è, usare comando 'pwd'.
echo 'ciao' # comando che printa a schermo quel che segue (da qui il nome echo, eco). In questo caso 'ciao'.
echo ciao > miofile # > permette di modificare l'output del comando. In questo caso, invece che printare a schermo sul terminale, l'output sarà printato sul file miofile.
nano miofile   # nano è un editor di testo usabile via bash. In questo caso aprirà il file miofile (se non fosse esistito, l'avrebbe creato). Per visualizzare e basta, si può anche usare cat.
ls -lah /home > miofile
nano miofile
ls -lah /dev > miofile
echo ciao > miofile # Attenzione: il comado > sovrascrive il contenuto del file destinazione...
echo ' mondo' >> miofile  # ... quindi se si vuole aggiungere contenuto (append), usare >>
mkdir 25-feb   # crea una directory chiamata 25-feb (in posizione relativa a dove si è con la bash se non direttamente esplicitato)
mv 25-feb/ 24-feb  # rinomina directory 25-feb in 24-feb. ATTENZIONE: rinomina solo se tale directory 24-feb non esiste. Se esistesse, la directory 25-deb verrebbe spostata DENTRO 24-feb
mv miofile miofile2 24-feb/   # è possibile spostare più file. Come al solito, l'ultimo argomento specifica la destinazione
cp 24-feb/miofile 24-feb/miofile2 25-feb/  # idem al mv, ma per la copia. Se non indicato diversamente, viene ricreato un file con lo stesso nome nella directory di destinazione.
rm 24-feb/   # rimuove file
rm -r 24-feb/  # il comando appena sopra, essendo il file una directory, darà errore. Per eliminare una directory e il suo contenuto, usare opzione -r



## ----  ESPLORAZIONE FILESYSTEM UNIX (VEDERE SLIDE PROF E WEB PER MAGGIORI DETTAGLI SU OGNI DIRECTORY VISTA) ---- 

cd /   # / indica la root directory, ossia il punto 'primordiale' da cui si sviluppa il filesystem
tree -L 1   # tree permette una visualizzazione migliore del contenuto della directory.
ls bin # visualizzazione contenuto bin, una delle directory visibili dalla root, nonchè una delle più importanti contenente tra l'altro tutti i programmi bash, inclusi quelli utilizzati normalmente come nano, cp, ecc.
ls etc # etc è un'altra directory importante, contenente in genere le varie configurazioni di sistema
ls dev # directory dev
ls media  # directory media
ls mnt # directory mnt
ls var # directory var
ls root # directory root (è la home di root, da non confondersi con la root directory che è /)

## ----  UTENTI & PERMESSI ---- 

whoami   # comando che visualizza a schermo nome dell'utente loggato. (whoami sta per 'chi sono io?')
# Ora volevamo vedere dei log di sistema, che si trovano in /var
cd /var
cd log
cat syslog # questo comando, come quello successivo, dava errore in quanto l'utente loggato, its-usr, non aveva i permessi di lettura necessari
cat messages 
useradd ludovico  # decidiamo di creare un nuovo utente di nome ludovico, ma non possiamo farlo in quanto è un'operazione che solo l'utente root (o un utente abilitato) può farlo
su root  # substitue user, serve ad accedere con un altro utente


#A questo punto, si passa all'utente root. [D'ora in poi per comodità qua indico con [NOME_UTENTE] lo switch ad un altro utente.

#[UTENTE ROOT]
su its-usr # una volta loggati come root (nota: all'atto pratico si apre una nuova shell nello stessa schermata su terminale, per questo motivo le due history sono divise), è possibile altresì passare ad un altro utente esistente, in questo caso si ritorna alla bash dell'utente its-usr

#[UTENTE ITS-USR]
su # ritornati come utente its-usr, ritorniamo root per effettuare delle operazioni. NOTA: 'su' senza specificare l'utente è equivalente al comando 'su root'

#[UTENTE ROOT]
cat /var/log/syslog # effettuo lo stesso comando provato prima da utente its-usr, questa volta avrà successo in quanto lo sto eseguendo da una bash loggata come root
tail -f /var/log/syslog # tail -f permette di visualizzare il file di log rimanendo in 'ascolto' di nuove entry nel log, è quindi una visualizzazione 'attiva' rispetto al cat che fa vedere il contenuto al momento dell'esecuzione del comando. Nota: l'"ascolto" del log si interrompe con Ctrl + c.
tree -L 1 # proviamo a eseguire tree, ma scopriamo che non risulta installato, quindi lo installiamo...
apt update   # comando usato per 'aggiornare' la lista delle repository remote da cui scaricare programmi tramite apt. Nota: NON viene fatto alcun aggiornamento effettivo dei pacchetti/programmi, ma è un'azione propedeutica all'installazione/aggiornamento di nuovi pacchetti
apt install tree # con apt-install è possibile scaricare e installare un programma presente nelle repository (precedentemente aggiornate). Nel nostro caso, si vuole installare tree ...
tree -L 1 /  # ...una volta completata l'installazione, è possibile usare tree. Lo facciamo con questo comando le cui opzioni -L 1 specificano di visualizzare solo fino al primo livello di sub-directory. / invece specifica la directory, quindi in questo caso la root directory
cd /etc  # Dopo questa parentesi sul tree e l'installazione di nuovi programmi bash, si ritorna a cosa si stava cercando di fare, ossia aggiungere un nuovo utente. Vado quindi nella directory /etc
ls | less # la directory etc ha moltissimi files. Noi dobbiamo trovare un file chiamato sudoers, ma non si ha la certezza sul nome. Si utilizza quindi ls | less per visualizzare l'output fornito da 'ls' attraverso less, che fornisce una visualizzazione paginata, molto utile nel caso il contenuto 'testuale' sia molto corposo. Attraverso less, possiamo scorrere i vari file presenti utilizzando le frecce, e poi uscire premendo 'q' (come accade con man, per esempio), senza quindi intasare la schermata del terminale.
cd sudoers.d # dal comando sopra, si è scoperto che sudoers è in realtà una directory e si chiama sudoers.d. Ci spostiamo quindi al suo interno.
nano its-usr  # creiamo quindi un file its-usr con nano e al suo interno inseriamo quanto necessario per abilitare l'utente its-usr ad eseguire comandi sudo. (vedere materiale fornito dal prof in questa lezione del 25 febbraio per maggiori dettagli)
exit # una volta scritto e salvato il file its-usr attraverso nano, il lavoro è fatto è l'utente its-usr può eseguire comandi sudo. Si può quindi uscire dalla bash di root, attraverso il comando exit (ritorna all'utente precedente l'ultimo su, in questo caso si ritornerà a its-usr)

#[UTENTE ITS-USR]
sudo useradd  # ora l'utente its-usr è in grado di eseguire il comando useradd
su  # ritorniamo di nuovo all'utente root

#[UTENTE ROOT]
passwd its-usr # l'utente root possiede privilegi altissimi, può quindi compiere attività relative anche ad altri utenti. In questo caso con passwd si vuole cambiare la password dell'utente its-usr
exit # si esce da root per tornate its-usr

#[UTENTE ITS-USR]
ls /root  # la directory /root è la home directory dell'utente root. E' quindi inaccessibile all'utente its-user senza averne i privilegi
sudo ls /root # ... dato che prima abbiamo aggiunto its-usr ai sudoers, possiamo usare il comando sudo per eseguire il comando con successo!
sudo ls -lah /root
cat /root/.bash_history  # idem sopra, è richiesto sudo!
sudo cat /root/.bash_history
su  # si passa alla shell dell'utente root...

#[UTENTE ROOT]
# si vuole ora creare un utente essendo loggato come root. Per fare questo sono sorti dei problemi dovuti al fatto che il comando useradd non risultava presente. Questo era dovuto al fatto che la bash root non riusciva ad associare il comando 'useradd' all'effettivo programma useradd. Per rimediare a questo, è stato necessario inserire il path completo a tale programma, in questo caso: /usr/sbin/useradd

man useradd # visionando il man relativo a useradd, si è visto come sia possibile inserire opzioni e parametri vari per accellerare il processo di creazione
/usr/sbin/useradd daniele # ad esempio è possibile aggiungere direttamente il nome dell'utente. Questo però non è sufficiente alla creazione completa dell'utente (vedere documento prof per le varie parti che è necessario creare...)
man adduser # adduser permette di creare utenti a più alto livello rispetto a useradd, ossia questo strumento permette la creazione dell'utente con, in più, la contemporea costruzione delle varie directory necessarie (tra cui quella in /home, ad esempio). E' quindi molto piu comodo. Il prof comunque utilizza useradd e forse ci invita velatamente a fare altrettanto.


## In seguito, per chiarire vari dubbi sorti in aula e in fad relativamente al concetto di utenti diversi/utente root/ecc. si son fatti vari esempi per far comprendere come:
#
# - Ogni utente debba essere inserito nella lista dei sudoers per poter compiere comandi sudo
# - Ogni utente abbia accesso alla propria directory dentro /home, e non possa visualizzare o modificare l'interno delle directory relative agli altri utenti. Questo è dovuto al fatto che solo l'utente ha i PRIVILEGI necessari (lettura, scrittura) all'interno della propria directory home. Per far comprendere meglio questo, il prof ha modificato al volo i privilegi (da utente root) di una di queste directory home, attraverso il comando chmod che vedremo successivamente. Dopo aver modificato questi privilegi, loggandoci con un utente A era possibile visualizzare e modificare i file della directory home dell'utente B (NOTA: è stato solo un esempio per far capire il concetto, nella pratica la modifica dei privilegi della directory home di un utente è una pratica assolutamente da evitare)
