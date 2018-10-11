use strict;
use warnings;
use strict;
use WWW::Mechanize;
use HTTP::Cookies;
use File::Copy qw/ move mv /;
use open ':std', ':encoding(UTF-8)';

#Fichier 
my $repertoire= 'Villages';
my $outfile1 = "Village1.html";
my $outfile2 = "Village2.html";
my $outfile3 = "Village3.html";
my $outfile4 = "Village4.html";
my $outfile5 = "Village5.html";
my $outfile6 = "Village6.html";
my $outfile7 = "Village7.html";
my $outfile8 = "Village8.html";
my $outfile9 = "Village9.html";
my $outfile10 = "Village10.html";
my $outfile11 = "Village11.html";
my $outfile12 = "Village12.html";
my $outfile13 = "Village13.html";
my $outfile14 = "Village14.html";
my $outfile15 = "Village15.html";

#Url du Serveur
my $serveur = "https://ts19.travian.fr";

#Url des villages
my $url1 = "https://ts19.travian.fr/spieler.php?newdid=17775&";
my $url2 = "";
my $url3 = "";
my $url4 = "";
my $url5 = "";
my $url6 = "";
my $url7 = "";
my $url8 = "";
my $url9 = "";
my $url10 = "";
my $url11 = "";
my $url12 = "";
my $url13 = "";
my $url14 = "";
my $url15 = "";

#Identifiant du compte
my $username = 'mdp';
my $password = 'password';

#Declaration du mech
my $mech = WWW::Mechanize->new();

#Prototypes des fonctions
sub Traitement{
	my ($url1,$outfile1)=@_;
	my $urlX = $url1;
	my $outfileX = $outfile1;
	$mech->get($urlX);
	my $output_page = $mech->content();
	open(OUTFILE, ">$outfileX");
	binmode(OUTFILE, ":utf8");
	print OUTFILE "$output_page";
	close(OUTFILE);	
	mv($outfileX, $repertoire);	
}

#Début du programme
mkdir ($repertoire,0755);
$mech->cookie_jar(HTTP::Cookies->new());
$mech->get($serveur);

# Connexion au serveur
$mech->field("name", $username);
$mech->field("password", $password);
$mech->click;

#Traitement des pages Html
Traitement($url1,$outfile1);
#Traitement($url2,$outfile2);
#Traitement($url3,$outfile3);
#Traitement($url4,$outfile4);
#Traitement($url5,$outfile5);
#Traitement($url6,$outfile6);
#Traitement($url7,$outfile7);
#Traitement($url8,$outfile8);
#Traitement($url9,$outfile9);
#Traitement($url10,$outfile10);
#Traitement($url11,$outfile11);

