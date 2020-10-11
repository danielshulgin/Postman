using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHouses : MonoBehaviour
{
	HouseDescription houseDescription;

	List<string> names_male = new List<string>()
	{
		"Ксавьер",
		"Константин",
		"Симон",
		"Тимон",
		"Кшиштоф",
		"Казимир",
		"Геральт",
		"Себастьян",
		"Ян",
		"Мартин",
		"Лукаш",
		"Виктор",
		"Анджей",
		"Матеуш",
		"Григор"
	};
	
	List<string> names_female = new List<string>()
	{
		"Анна",
		"Иванка",
		"Василиса",
		"Валерия",
		"Габриела",
		"Дита",
		"София",
		"Мария",
		"Изабелла",
		"Кристина",
		"Лидия",
		"Матильда",
		"Люси",
		"Ева",
		"Дана"
	};
	
	List<string> surnames = new List<string>()
	{
		"Миллер",
		"Йоффе",
		"Корсак",
		"Гесс",
		"Бабик",
		"Западловски",
		"Новик",
		"Левандовски",
		"Таубвурсель",
		"Дохтур",
		"Лански",
		"Лутрин",
		"Фа́бин",
		"Фаби́н",
		"Кафка",
		"Земанек",
		"Жижка",
		"Саболь",
		"Замойски",
		"Завацки",
		"Полубински",
		"Лещински",
		"Мазур",
		"Кравчик",
		"Рачко",
		"Мицкевич",
		"Ожешко",
		"Грифич",
		"Пузын",
		"Бирон",
		"Мышковски",
		"Буремски",
		"Друцки",
		"Корецки",
		"Исламски",
		"Олелькович",
		"Ружински",
		"Сангушко",
		"Калонимус",
		"Лурье",
		"Рубинштейн",
		"Жолондз",
		"Пичхадзе",
		"Фурман",
		"Лернер",
		"Вайс",
		"Коган",
		"Кац",
		"Зарудински",
		"Рахель",
		"Горилленко",
		"Мартышко",
		"Сопленски",
		"Парашко",
		"Черкасс",
		"Скрипалько",
		"Пальчевски",
		"Грязнух",
		"Рофленски",
		"Порохенко",
		"Узумаки",
		"Воробински",
		"Сепаренски",
		"Бомжеус",
		"Ларник",
		"Желтенски",
		"Фреско",
		"Мемнич",
		"Винник",
		"Аутински"
	};
	
	List<string> sex = new List<string>()
	{
		"Мужской",
		"Женский"
	};
	
	List<string> age = new List<string>()
	{
		"Молодой(ая)",
		"Взрослый(ая)", 
		"Пожилой(ая)"
	};
	
	List<string> hair_color = new List<string>()
	{
		"Светлые",
		"Рыжие",
		"Темные"
	};
	
	List<string> height = new List<string>()
	{
		"Высокий",
		"Средний",
		"Низкий"
	};
	
	List<string> body = new List<string>()
	{
		"Есть лишний вес",
		"Без лишнего веса"
	};
	
	List<string> car = new List<string>()
	{
		"Есть",
		"Нету"
	};
	
	List<string> pat = new List<string>()
	{
		"Есть",
		"Нету"
	};
	
	List<string> married = new List<string>()
	{
		"Да",
		"Нет"
	};
	
	private static System.Random rnd;
	
    // Start is called before the first frame update
    void Start()
    {
        GeneratePeoples();
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	void OnMouseDown(){ 
		print(gameObject.transform.GetSiblingIndex()); 
	} 
	
	public void GeneratePeoples() {
		List<List<string>> peoples = new List<List<string>>();
	
		rnd = new System.Random();
		
		for (int i = 0; i < 100; i++) {
			
			
			string people_sex = sex[rnd.Next(0, sex.Count)];
			string people_name;
			if(people_sex == "Мужской") {
				people_name = names_male[rnd.Next(0, names_male.Count)];
			}
			else {
				people_name = names_female[rnd.Next(0, names_female.Count)];
			}
			
			string people_surname = surnames[rnd.Next(0, surnames.Count)];
			
			string people_age = age[rnd.Next(0, age.Count)];
			
			string people_hair_color = hair_color[rnd.Next(0, hair_color.Count)];
			
			string people_height = height[rnd.Next(0, height.Count)];
			
			string people_body = body[rnd.Next(0, body.Count)];
			
			string people_car = car[rnd.Next(0, car.Count)];
			
			string people_pat = pat[rnd.Next(0, pat.Count)];
			
			string people_married = married[rnd.Next(0, married.Count)];

            HouseDescription.housesWithDescription[i].house = GameObject.Find("village").transform.GetChild(i).gameObject;
            HouseDescription.housesWithDescription[i].description = 
                people_name + people_surname
                + people_age + people_hair_color + people_height
                + people_body + people_car + people_pat + people_married;
				
                //GameObject.Find("BlockHouse");
			
			/*
			Debug.Log("Пол: " + people_sex);
			Debug.Log("Имя: " + people_name);
			Debug.Log("Фамилия: " + people_surname);
			Debug.Log("Возраст: " + people_age);
			Debug.Log("Цвет волос: " + people_hair_color);
			Debug.Log("Рост: " + people_height);
			Debug.Log("Телосложение: " + people_body);
			Debug.Log("Машина: " + people_car);
			Debug.Log("Домашний питомец: " + people_pat);
			Debug.Log("В браке?: " + people_married);
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			Debug.Log("\n");
			
			
			peoples.Add(new List<string>() 
			{
				people_sex, 
				people_name, 
				people_surname, 
				people_age, 
				people_hair_color, 
				people_height, 
				people_body, 
				people_car, 
				people_pat, 
				people_married
			}); */
			//Console.WriteLine(i);
		}
	}
}
