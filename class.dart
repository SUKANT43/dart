void main(){
  var dosa=new MenuItem("dosa",20);
  var pizza-new Pizza(["mushrroms","peppers"],"veg valcono",23.5);
  print(dosa.title);
}


class MenuItem{
  String title;
  double price;

MenuItem( this.title,this.price);

}

class Pizza extends MenuItem{
  List<String> toopings;
  Pizza(this.toopings,super.title,super.price);
}