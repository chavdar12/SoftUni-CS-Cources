using Ex003;

namespace Ex003Tests;

[TestFixture]
public class ExtendedDatabaseTests
{
    [SetUp]
    public void Setup()
    {
        firstPerson = new Person(123, "Kircho");
        secondPerson = new Person(321, "Mircho");
        people = new[] { firstPerson, secondPerson };
        extDatabase = new ExtendedDatabase();
    }

    private const int AllowedCapacity = 16;
    private ExtendedDatabase extDatabase;
    private Person[] people;
    private Person firstPerson;
    private Person secondPerson;

    private Person[] FillCollection()
    {
        var persons = new Person[AllowedCapacity];
        for (var i = 0; i < 16; i++)
        {
            var userName = "Guy" + i;
            var person = new Person(i + 1, userName);
            persons[i] = person;
        }

        return persons;
    }

    [Test]
    public void VerifyConstructor()
    {
        var db = new ExtendedDatabase(people);
        Assert.IsNotNull(db);
    }

    [Test]
    public void VerifyCollectionSize()
    {
        people = [firstPerson, secondPerson, new Person(1, "pepe")];
        Assert.That(people, Has.Length.EqualTo(3));
    }

    [Test]
    public void VerifyAddRangeMethod()
    {
        const int expected = 2;
        extDatabase = new ExtendedDatabase(people);
        Assert.That(extDatabase.Count, Is.EqualTo(expected), "This method doesn't work right!");
    }

    [Test]
    public void CollectionThrowsExceptionWhenGoingOverTheCapacity()
    {
        var data = new Person[AllowedCapacity + 1];
        var error = Assert.Throws<ArgumentException>(() => extDatabase = new ExtendedDatabase(data));
        Assert.That(error?.Message, Is.EqualTo("Provided data length should be in range [0..16]!"));
    }

    [Test]
    public void VerifyAddMethod()
    {
        extDatabase = new ExtendedDatabase(people);
        var newPerson = new Person(777, "Bojkov");
        extDatabase.Add(newPerson);
        const int expected = 3;
        Assert.That(extDatabase.Count, Is.EqualTo(expected));
    }

    [Test]
    public void AddMethodThrowsExceptionWhenGoingOverTheCapacity()
    {
        var temp = FillCollection();
        extDatabase = new ExtendedDatabase(temp);
        Assert.Throws<InvalidOperationException>(() => extDatabase.Add(new Person(11, "Pepe")));
    }

    [Test]
    public void AddMethodThrowsExceptionIfCollectionSizeIs16()
    {
        var temp = FillCollection();
        extDatabase = new ExtendedDatabase(temp);
        Assert.Throws<InvalidOperationException>(() => extDatabase.Add(null));
    }

    [Test]
    public void AddMethodThrowsExceptionWhenTheSameUserIsFound()
    {
        extDatabase.Add(firstPerson);
        Assert.Throws<InvalidOperationException>(() => extDatabase.Add(new Person(11, "Kircho")));
    }

    [Test]
    public void AddMethodThrowsExceptionWhenTheSameIdIsFound()
    {
        extDatabase.Add(firstPerson);
        Assert.Throws<InvalidOperationException>(() => extDatabase.Add(new Person(123, "Gandalf")));
    }

    [Test]
    public void VerifyRemoveMethod()
    {
        extDatabase = new ExtendedDatabase(people);
        extDatabase.Remove();
        var expected = 1;
        Assert.That(extDatabase.Count, Is.EqualTo(expected), "This method doesn't work right!");
    }

    [Test]
    public void RemoveMethodThrowsExceptionWhenCollectionIsEmpty()
    {
        extDatabase = new ExtendedDatabase();
        Assert.Throws<InvalidOperationException>(() => extDatabase.Remove());
    }

    [Test]
    public void VerifyFindByUserNameMethod()
    {
        extDatabase = new ExtendedDatabase(people);
        var target = extDatabase.FindByUsername(secondPerson.UserName);
        Assert.That(target.UserName, Is.EqualTo(secondPerson.UserName), "This method doesn't work right!");
        Assert.That(target.Id, Is.EqualTo(secondPerson.Id), "This method doesn't work right!");
    }

    [Test]
    public void FindByUserNameMethodThrowsExceptionWhenParameterIsNull()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<ArgumentNullException>(() => extDatabase.FindByUsername(null));
    }

    [Test]
    public void FindByUserNameMethodThrowsExceptionWhenParameterIsEmpty()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<ArgumentNullException>(() => extDatabase.FindByUsername(string.Empty));
    }

    [Test]
    public void FindByUserNameMethodThrowsExceptionWhenUserIsNotFound()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<InvalidOperationException>(() => extDatabase.FindByUsername("Mile Kitic"));
    }

    [Test]
    public void FindByUserNameMethodIsCaseSensitive()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<InvalidOperationException>(() => extDatabase.FindByUsername("MIRCHO"));
    }

    [Test]
    public void VerifyFindByIdMethod()
    {
        extDatabase = new ExtendedDatabase(people);
        var target = extDatabase.FindById(firstPerson.Id);
        Assert.That(target.Id, Is.EqualTo(firstPerson.Id), "This method doesn't work right!");
        Assert.That(target.UserName, Is.EqualTo(firstPerson.UserName), "This method doesn't work right!");
    }

    [Test]
    public void FindByIdMethodThrowsExceptionWhenParameterIsNegative()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<ArgumentOutOfRangeException>(() => extDatabase.FindById(-123));
    }

    [Test]
    public void FindByIdMethodThrowsExceptionWhenIdIsNotFound()
    {
        extDatabase = new ExtendedDatabase(people);
        Assert.Throws<InvalidOperationException>(() => extDatabase.FindById(666));
    }
}