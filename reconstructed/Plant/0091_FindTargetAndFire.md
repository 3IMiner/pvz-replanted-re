# System.Boolean FindTargetAndFire(System.Int32 theRow, Reloaded.Gameplay.PlantWeapon thePlantWeapon)

- 类：`Plant`
- 汇编行数：517

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB640h],0
	mov edi,r8d
	mov esi,edx
	mov rbx,rcx
	jne short 00000001806AFBA0h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C688C0h]
	call 00000001804FEB70h
	lea rcx,[184C984C0h]
	call 00000001804FEB70h
	lea rcx,[184C7DBB0h]
	call 00000001804FEB70h
	lea rcx,[184C98598h]
	call 00000001804FEB70h
	lea rcx,[184C88268h]
	call 00000001804FEB70h
	lea rcx,[184C687E8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB640h],1
	xor r9d,r9d
	mov r8d,edi
	mov edx,esi
	mov rcx,rbx
	call 00000001806B0040h
	mov rbp,rax
	test rax,rax
	je near ptr 00000001806B001Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	xor edx,edx
	call 00000001807C7650h
	cmp dword ptr [rbx+70h],1Ch
	jne short 00000001806AFC52h
	cmp edi,1
	jne short 00000001806AFC52h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	mov r8d,3
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm3,dword ptr [183C33EF4h]
	mov r8d,3
	mov rdx,[184C88268h]
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	movzx eax,dil
	mov dword ptr [rbx+0DCh],1Ah
	jmp near ptr 00000001806B001Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	mov rdx,[184C984C0h]
	xor r9d,r9d
	mov r8d,2
	call 00000001807C8940h
	test al,al
	je near ptr 00000001806AFD9Ah
	movsxd rcx,dword ptr [rbx+70h]
	test ecx,ecx
	je short 00000001806AFCA5h
	cmp ecx,34h
	ja short 00000001806AFC9Ch
	mov rdx,100000100400A0h
	bt rdx,rcx
	jb short 00000001806AFCA5h
	cmp ecx,28h
	jne near ptr 00000001806AFD9Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	mov r8d,2
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm3,dword ptr [183C33EF4h]
	mov r8d,2
	mov rdx,[184C7DBB0h]
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	cmp dword ptr [rbx+70h],7
	mov dword ptr [rbx+0DCh],23h
	je short 00000001806AFD63h
	cmp dword ptr [rbx+70h],1Ch
	je short 00000001806AFD63h
	cmp dword ptr [rbx+70h],34h
	je short 00000001806AFD63h
	cmp dword ptr [rbx+70h],28h
	jne near ptr 00000001806B0018h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm1,dword ptr [183C33FD4h]
	xor r9d,r9d
	mov r8d,2
	call 00000001807C8740h
	mov al,1
	mov dword ptr [rbx+0DCh],64h
	jmp near ptr 00000001806B001Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	movss xmm1,dword ptr [183C33E28h]
	xor r9d,r9d
	mov r8d,2
	call 00000001807C8740h
	mov al,1
	mov dword ptr [rbx+0DCh],1Ah
	jmp near ptr 00000001806B001Ah
	cmp dword ptr [rbx+88h],20h
	je near ptr 00000001806AFFDCh
	cmp dword ptr [rbx+70h],2Ah
	je near ptr 00000001806AFF9Ch
	cmp dword ptr [rbx+70h],2Bh
	je near ptr 00000001806AFF5Ch
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	mov rdx,[184C984C0h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8940h
	mov rcx,rbx
	test al,al
	jne short 00000001806AFE02h
	mov r9d,edi
	mov qword ptr [rsp+20h],0
	mov r8d,esi
	mov rdx,rbp
	call 00000001806B0580h
	mov al,1
	jmp near ptr 00000001806B001Ah
	movss xmm0,dword ptr [183C33EF4h]
	mov r9d,14h
	mov rdx,[184C984C0h]
	mov r8d,3
	mov qword ptr [rsp+28h],0
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	cmp dword ptr [rbx+70h],0Ah
	je near ptr 00000001806AFF8Eh
	cmp dword ptr [rbx+70h],8
	je near ptr 00000001806AFF4Bh
	cmp dword ptr [rbx+70h],0Dh
	je near ptr 00000001806AFF3Ah
	cmp dword ptr [rbx+70h],20h
	je near ptr 00000001806AFF29h
	cmp dword ptr [rbx+70h],27h
	je near ptr 00000001806AFF18h
	cmp dword ptr [rbx+70h],2Ch
	je near ptr 00000001806AFF18h
	cmp dword ptr [rbx+70h],22h
	je short 00000001806AFE91h
	cmp dword ptr [rbx+70h],1Ah
	mov eax,23h
	mov ecx,1Dh
	cmovne eax,ecx
	mov [rbx+0DCh],eax
	mov al,1
	jmp near ptr 00000001806B001Ah
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AFEA6h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,4
	call 00000001806CBE80h
	test eax,eax
	jne short 00000001806AFF07h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	mov rdx,[184C687E8h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8DB0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B002Fh
	mov rdx,[184C688C0h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8DB0h
	mov dword ptr [rbx+88h],27h
	mov dword ptr [rbx+0DCh],1Eh
	mov al,1
	jmp near ptr 00000001806B001Ah
	mov dword ptr [rbx+0DCh],24h
	mov al,1
	jmp near ptr 00000001806B001Ah
	mov dword ptr [rbx+0DCh],20h
	mov al,1
	jmp near ptr 00000001806B001Ah
	mov dword ptr [rbx+0DCh],19h
	mov al,1
	jmp near ptr 00000001806B001Ah
	mov dword ptr [rbx+0DCh],1Dh
	mov al,1
	jmp near ptr 00000001806B001Ah
	movss xmm0,dword ptr [183C33C60h]
	mov r9d,0Ah
	mov rdx,[184C984C0h]
	mov r8d,3
	mov qword ptr [rsp+28h],0
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov dword ptr [rbx+0DCh],32h
	mov al,1
	jmp short 00000001806B001Ah
	movss xmm0,dword ptr [183C33FA4h]
	mov r9d,14h
	mov rdx,[184C984C0h]
	mov r8d,3
	mov qword ptr [rsp+28h],0
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov al,1
	mov dword ptr [rbx+0DCh],0C8h
	jmp short 00000001806B001Ah
	movss xmm0,dword ptr [183C33EF4h]
	mov r9d,14h
	mov rdx,[184C98598h]
	mov r8d,3
	mov qword ptr [rsp+28h],0
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov dword ptr [rbx+0DCh],17h
	mov al,1
	mov rbx,[rsp+40h]
	mov rbp,[rsp+48h]
	mov rsi,[rsp+50h]
	add rsp,30h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -48
	007 Compare [0x184EEB640], 0
	008 Move rdi, r8
	009 Move rsi, rdx
	010 Move rbx, rcx
	011 JumpIfNotEqual {27}
	012 LoadAddress rcx, [0x184C2AFC0]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C688C0]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184C984C0]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 LoadAddress rcx, [0x184C7DBB0]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C98598]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C88268]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 LoadAddress rcx, [0x184C687E8]
	025 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	026 Move [0x184EEB640], 1
	027 Move r9, 0
	028 Move r8, rdi
	029 Move rdx, rsi
	030 Move rcx, rbx
	031 Call Plant.FindTargetZombie, rcx, rdx, r8
	032 Move rbp, rax
	033 Compare rax, 0
	034 JumpIfEqual {251}
	035 Move rcx, [rbx+320]
	036 Compare rcx, 0
	037 JumpIfEqual {258}
	038 Move rdx, 0
	039 Call ReloadedCharacterController.DisableBlink, rcx, rdx
	040 Compare [rbx+112], 28
	041 JumpIfNotEqual {63}
	042 Compare rdi, 1
	043 JumpIfNotEqual {63}
	044 Move rcx, [rbx+320]
	045 Compare rcx, 0
	046 JumpIfEqual {258}
	047 Move xmm1, [0x183C33DBC]
	048 Move r9, 0
	049 Move r8, 3
	050 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	051 Move rcx, [rbx+320]
	052 Compare rcx, 0
	053 JumpIfEqual {258}
	054 Move xmm3, [0x183C33EF4]
	055 Move r8, 3
	056 Move rdx, "splitpea_shooting"
	057 Move stack:0x28, 0
	058 Move stack:0x20, 3
	059 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	060 Move rax, rdi
	061 Move [rbx+220], 26
	062 Goto {251}
	063 Move rcx, [rbx+320]
	064 Compare rcx, 0
	065 JumpIfEqual {258}
	066 Move rdx, "anim_shooting"
	067 Move r9, 0
	068 Move r8, 2
	069 Call ReloadedCharacterController.TrackExistsOnTrack, rcx, rdx, r8
	070 Compare rax, 0
	071 JumpIfEqual {127}
	072 Move rcx, [rbx+112]
	073 Compare rcx, 0
	074 JumpIfEqual {82}
	075 Compare rcx, 52
	076 JumpIfGreater {80}
	077 Move rdx, 0x100000100400A0
	078 NotImplemented "bt rdx,rcx"
	079 JumpIfLess {82}
	080 Compare rcx, 40
	081 JumpIfNotEqual {127}
	082 Move rcx, [rbx+320]
	083 Compare rcx, 0
	084 JumpIfEqual {258}
	085 Move xmm1, [0x183C33DBC]
	086 Move r9, 0
	087 Move r8, 2
	088 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	089 Move rcx, [rbx+320]
	090 Compare rcx, 0
	091 JumpIfEqual {258}
	092 Move xmm3, [0x183C33EF4]
	093 Move r8, 2
	094 Move rdx, "shooting"
	095 Move stack:0x28, 0
	096 Move stack:0x20, 3
	097 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	098 Compare [rbx+112], 7
	099 Move [rbx+220], 35
	100 JumpIfEqual {117}
	101 Compare [rbx+112], 28
	102 JumpIfEqual {117}
	103 Compare [rbx+112], 52
	104 JumpIfEqual {117}
	105 Compare [rbx+112], 40
	106 JumpIfNotEqual {250}
	107 Move rcx, [rbx+320]
	108 Compare rcx, 0
	109 JumpIfEqual {258}
	110 Move xmm1, [0x183C33FD4]
	111 Move r9, 0
	112 Move r8, 2
	113 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	114 Move rax, 1
	115 Move [rbx+220], 100
	116 Goto {251}
	117 Move rcx, [rbx+320]
	118 Compare rcx, 0
	119 JumpIfEqual {258}
	120 Move xmm1, [0x183C33E28]
	121 Move r9, 0
	122 Move r8, 2
	123 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	124 Move rax, 1
	125 Move [rbx+220], 26
	126 Goto {251}
	127 Compare [rbx+136], 32
	128 JumpIfEqual {241}
	129 Compare [rbx+112], 42
	130 JumpIfEqual {230}
	131 Compare [rbx+112], 43
	132 JumpIfEqual {219}
	133 Move rcx, [rbx+320]
	134 Compare rcx, 0
	135 JumpIfEqual {258}
	136 Move rdx, "anim_shooting"
	137 Move r9, 0
	138 Move r8, 0
	139 Call ReloadedCharacterController.TrackExistsOnTrack, rcx, rdx, r8
	140 Move rcx, rbx
	141 Compare rax, 0
	142 JumpIfNotEqual {150}
	143 Move r9, rdi
	144 Move stack:0x20, 0
	145 Move r8, rsi
	146 Move rdx, rbp
	147 Call Plant.Fire, rcx, rdx, r8, r9
	148 Move rax, 1
	149 Goto {251}
	150 Move xmm0, [0x183C33EF4]
	151 Move r9, 20
	152 Move rdx, "anim_shooting"
	153 Move r8, 3
	154 Move stack:0x28, 0
	155 Move stack:0x20, xmm0
	156 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	157 Compare [rbx+112], 10
	158 JumpIfEqual {227}
	159 Compare [rbx+112], 8
	160 JumpIfEqual {216}
	161 Compare [rbx+112], 13
	162 JumpIfEqual {213}
	163 Compare [rbx+112], 32
	164 JumpIfEqual {210}
	165 Compare [rbx+112], 39
	166 JumpIfEqual {207}
	167 Compare [rbx+112], 44
	168 JumpIfEqual {207}
	169 Compare [rbx+112], 34
	170 JumpIfEqual {180}
	171 Compare [rbx+112], 26
	172 Move rax, 35
	173 Move rcx, 29
	174 JumpIfEqual {176}
	175 Move rax, rcx
	176 Nop 
	177 Move [rbx+220], rax
	178 Move rax, 1
	179 Goto {251}
	180 Move rcx, typeof(Reloaded.Gameplay.Common)
	181 Compare [rcx+228], 0
	182 JumpIfNotEqual {184}
	183 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	184 Move rdx, 0
	185 Move rcx, 4
	186 Call Common.Rand, rcx, rdx
	187 Compare rax, 0
	188 JumpIfNotEqual {204}
	189 Move rcx, [rbx+320]
	190 Compare rcx, 0
	191 JumpIfEqual {258}
	192 Move rdx, "Cornpult_butter"
	193 Move r9, 0
	194 Move r8, 0
	195 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	196 Move rcx, [rbx+320]
	197 Compare rcx, 0
	198 JumpIfEqual {258}
	199 Move rdx, "Cornpult_kernal"
	200 Move r9, 0
	201 Move r8, 0xFFFFFFFF
	202 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	203 Move [rbx+136], 39
	204 Move [rbx+220], 30
	205 Move rax, 1
	206 Goto {251}
	207 Move [rbx+220], 36
	208 Move rax, 1
	209 Goto {251}
	210 Move [rbx+220], 32
	211 Move rax, 1
	212 Goto {251}
	213 Move [rbx+220], 25
	214 Move rax, 1
	215 Goto {251}
	216 Move [rbx+220], 29
	217 Move rax, 1
	218 Goto {251}
	219 Move xmm0, [0x183C33C60]
	220 Move r9, 10
	221 Move rdx, "anim_shooting"
	222 Move r8, 3
	223 Move stack:0x28, 0
	224 Move rcx, rbx
	225 Move stack:0x20, xmm0
	226 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	227 Move [rbx+220], 50
	228 Move rax, 1
	229 Goto {251}
	230 Move xmm0, [0x183C33FA4]
	231 Move r9, 20
	232 Move rdx, "anim_shooting"
	233 Move r8, 3
	234 Move stack:0x28, 0
	235 Move rcx, rbx
	236 Move stack:0x20, xmm0
	237 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	238 Move rax, 1
	239 Move [rbx+220], 200
	240 Goto {251}
	241 Move xmm0, [0x183C33EF4]
	242 Move r9, 20
	243 Move rdx, "anim_shootinghigh"
	244 Move r8, 3
	245 Move stack:0x28, 0
	246 Move rcx, rbx
	247 Move stack:0x20, xmm0
	248 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	249 Move [rbx+220], 23
	250 Move rax, 1
	251 Move rbx, stack:0x40
	252 Move rbp, stack:0x48
	253 Move rsi, stack:0x50
	254 ShiftStack 48
	255 Move rdi, stack:0x0
	256 ShiftStack 8
	257 Return rax
	258 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
