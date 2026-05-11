using System;
using Xunit;
using MAS3;
using System.Linq;

namespace MAS3.Tests;

public class DisjointInheritanceTests
{
    [Fact]
    public void TeamMember_ExtensionContainsCreatedInstances()
    {
        // Act
        var initialCount = TeamMember.GetExtension().Count;
        var engineer = new Engineer(1000m);
        var mechanic = new Mechanic(10, 50m);

        // Assert
        var extension = TeamMember.GetExtension();
        Assert.True(extension.Count >= initialCount + 2);
        Assert.Contains(engineer, extension);
        Assert.Contains(mechanic, extension);
    }
    
    [Fact]
    public void Disjoint_EngineerAndMechanicAreDisjoint()
    {
        // Arrange
        var engineer = new Engineer(50000m);
        var mechanic = new Mechanic(10, 50m);
        
        // Assert
        Assert.IsNotType<Mechanic>(engineer);
        Assert.IsNotType<Engineer>(mechanic);
        Assert.IsAssignableFrom<TeamMember>(engineer);
        Assert.IsAssignableFrom<TeamMember>(mechanic);
    }
    
    [Fact]
    public void Engineer_CalculateBonus_CalculatesCorrectly()
    {
        // Arrange
        var baseSalary = 10000m;
        var engineer = new Engineer(baseSalary);
        
        // Act
        var bonus = engineer.CalculateBonus();
        
        // Assert
        Assert.Equal(2000m, bonus);
    }
    
    [Fact]
    public void Mechanic_CalculateBonus_CalculatesCorrectly()
    {
        // Arrange
        var overtimeHours = 10;
        var hourlyRate = 50m;
        var mechanic = new Mechanic(overtimeHours, hourlyRate);
        
        // Act
        var bonus = mechanic.CalculateBonus();
        
        // Assert
        Assert.Equal(750m, bonus); // 50 * 10 * 1.5
    }
}
