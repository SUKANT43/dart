import 'package:http/http.dart' as http;

void main() {
  fetchData();
}

Future<void> fetchData() async {
  var url = Uri.parse('jsonplaceholder.typicode.com', '/posts/1');

  final response = await http.get(url);

  print(response.statusCode);
  print(response.body);
}
