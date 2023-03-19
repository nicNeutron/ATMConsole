using System;

public class CardHolder
{
    private String _cardNum;
    private int _pin;
    private String _firstName;
    private String _lastName;
    private double _balance;

    public CardHolder(String cardNum, int pin, string firstName, string lastName, double balance)
    {
        this._cardNum = cardNum;
        this._pin = pin;
        this._firstName = firstName;
        this._lastName = lastName;
        this._balance = balance;
    }

    public String CardNum
    {
        get { return _cardNum; }
        set { _cardNum = value; }
    }

    public String FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public String LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

}