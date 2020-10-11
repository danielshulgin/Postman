using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharacterParametrVariantsSO", menuName = "CharacterParametrVariantsSO", order = 0)]
public class CharacterParametrVariantsSO : ScriptableObject
{
    	
	public List<string> names_male = new List<string>()
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
	
	public List<string> names_female = new List<string>()
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
	
	public List<string> surnames = new List<string>()
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
	
	public List<string> sex = new List<string>()
	{
		"Мужской",
		"Женский"
	};
	
	public List<string> age = new List<string>()
	{
		"Молодой(ая)",
		"Взрослый(ая)", 
		"Пожилой(ая)"
	};
	
	public List<string> hair_color = new List<string>()
	{
		"Светлые",
		"Рыжие",
		"Темные"
	};
	
	public List<string> height = new List<string>()
	{
		"Высокий",
		"Средний",
		"Низкий"
	};
	
	public List<string> body = new List<string>()
	{
		"Есть лишний вес",
		"Без лишнего веса"
	};
	
	public List<string> car = new List<string>()
	{
		"Есть",
		"Нету"
	};
	
	public List<string> pat = new List<string>()
	{
		"Есть",
		"Нету"
	};
	
	public List<string> married = new List<string>()
	{
		"Да",
		"Нет"
	};
}
