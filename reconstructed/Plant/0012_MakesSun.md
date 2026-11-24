# System.Boolean MakesSun()

- 类：`Plant`
- 汇编行数：23

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+70h],1
	je short 00000001806B31A4h
	cmp dword ptr [rcx+70h],29h
	je short 00000001806B31A4h
	cmp dword ptr [rcx+70h],9
	sete al
	ret
	mov al,1
	ret

ISIL:
	001 Compare [rcx+112], 1
	002 JumpIfEqual {8}
	003 Compare [rcx+112], 41
	004 JumpIfEqual {8}
	005 Compare [rcx+112], 9
	006 NotImplemented "sete al"
	007 Return rax
	008 Move rax, 1
	009 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
