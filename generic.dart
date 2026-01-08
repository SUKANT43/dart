void main(){
    var food=Collection<Collection>(
      'Menu Items',
      ["egg","chicken","mutton"]
    );

    print(food.randomItem());
}

class Collection<T>{
  String name;
  List data;  //List<T> this alows to add another class or whatever it is this allows to store from outside of the class where we creating a instance
  Collection(this.name,this.data);

  randomItem(){
    data.shuffle();
    return data[0];
  }
}