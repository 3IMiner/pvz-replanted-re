# System.Boolean IsUpgrade(Reloaded.Gameplay.SeedType theSeedtype)

- 类：`Plant`
- 汇编行数：25

## 反汇编

```asm

Disassembly:
	lea eax,[rcx-28h]
	test eax,0FFFFFFF8h
	jne short 00000001806B2532h
	cmp ecx,2Bh
	je short 00000001806B2535h
	mov al,1
	ret
	cmp ecx,2Bh
	sete al
	ret

ISIL:
	001 LoadAddress rax, [rcx-40]
	002 Compare rax, 0xFFFFFFF8
	003 JumpIfNotEqual {8}
	004 Compare rcx, 43
	005 JumpIfEqual {9}
	006 Move rax, 1
	007 Return rax
	008 Compare rcx, 43
	009 NotImplemented "sete al"
	010 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
